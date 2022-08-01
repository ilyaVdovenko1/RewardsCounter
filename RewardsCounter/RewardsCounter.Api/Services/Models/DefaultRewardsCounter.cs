using RewardsCounter.Api.Configuration.Interfaces;
using RewardsCounter.Api.Domain;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Services.Interfaces;

namespace RewardsCounter.Api.Services.Models;

/// <summary>
/// Implements default logic of counting reward.
/// </summary>
public class DefaultRewardsCounter : IRewardsCounter
{
    private readonly IRewardsCounterConfiguration countingConfiguration;
    private readonly ILogger<DefaultRewardsCounter>? logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultRewardsCounter"/> class.
    /// </summary>
    /// <param name="countingConfiguration">Represents reward rules.</param>
    /// <param name="logger">Logger provider.</param>
    public DefaultRewardsCounter(IRewardsCounterConfiguration countingConfiguration, ILogger<DefaultRewardsCounter>? logger)
    {
        this.countingConfiguration = countingConfiguration;
        this.logger = logger;
    }

    /// <summary>
    /// Counts reward through all transactions for concrete client in default way.
    /// </summary>
    /// <param name="transactions">Transactions to process.</param>
    /// <param name="customer">Concrete client.</param>
    /// <returns>Default reward.</returns>
    public Reward CountReward(IEnumerable<Transaction> transactions, Customer customer)
    {
        if (customer is null)
        {
            this.logger?.LogWarning("Unexpected null ref: customer is null.");
            throw new ArgumentNullException(nameof(customer));
        }

        this.logger?.LogTrace("Processing reward for client with id {Id}", customer.Id);
        var fittingTransactions = transactions.Where(transaction => transaction.ClientId == customer.Id);

        var clientTransactionsSum = this.CountReward(fittingTransactions);
        this.logger?.LogTrace("Processed reward for client with id {Id}. Reward: {Reward}", customer.Id, clientTransactionsSum);

        return new Reward()
        {
            Customer = customer,
            PointsTotal = clientTransactionsSum,
        };
    }

    /// <summary>
    /// Counts reward through transactions in [start; end] interval for concrete client in default way.
    /// </summary>
    /// <param name="transactions">Transactions to process.</param>
    /// <param name="customer">Concrete client.</param>
    /// <param name="start">Start of processing period.</param>
    /// <param name="end">End of processing period.</param>
    /// <returns>Default reward.</returns>
    public Reward CountReward(IEnumerable<Transaction> transactions, Customer customer, DateTime start, DateTime end)
    {
        if (customer is null)
        {
            this.logger?.LogWarning("Unexpected null ref: customer is null.");
            throw new ArgumentNullException(nameof(customer));
        }

        this.logger?.LogTrace("Processing reward for client with id {Id} from {StartDate} to {FinishDate}", customer.Id);

        if (start > end)
        {
            this.logger?.LogWarning("Start date was greater then end.");
            throw new InvalidRequestedPeriodException(nameof(start), "Start value in period can not be less then end.");
        }

        if (start < customer.CreationDate)
        {
            this.logger?.LogWarning("Start date was greater then user creation date.");
            throw new InvalidRequestedPeriodException(nameof(start), "Start value can not be greater then customer registration date.");
        }

        var fittingTransactions = transactions.Where(item => item.Timestamp >= start && item.Timestamp <= end).ToList();

        var points = this.CountReward(fittingTransactions);
        var monthRewards = this.CountMonthsRewards(fittingTransactions, start, end);

        return new Reward()
        {
            Customer = customer,
            MonthReward = monthRewards,
            PointsTotal = points,
        };
    }

    private IEnumerable<MonthReward> CountMonthsRewards(IEnumerable<Transaction> transactions, DateTime start,
        DateTime end)
    {
        var monthRewards = new List<MonthReward>();

        for (var i = start; i < end; i = i.AddMonths(1))
        {
            monthRewards.Add(this.CountMonthReward(transactions, i.Month, i.Year));
        }

        return monthRewards;
    }

    private MonthReward CountMonthReward(IEnumerable<Transaction> transactions, int month, int year)
    {
        var fittingTransactions = transactions.Where(t => t.Timestamp.Month == month);
        var monthReward = this.CountReward(fittingTransactions);
        return new MonthReward()
        {
            Bonus = monthReward,
            Month = month,
            Year = year,
        };
    }

    private decimal CountReward(IEnumerable<Transaction> transactions)
    {
        var clientTransactionsSum =
            transactions.Where(transaction => transaction.Sum > 0).Sum(item => item.Sum);

        var fittingBonuses = this.countingConfiguration.Rewards.Where(rule => rule.Sum <= clientTransactionsSum);

        var points =
            fittingBonuses.Sum(fittingBonus => (clientTransactionsSum - fittingBonus.Sum) * fittingBonus.Points);

        this.logger?.LogTrace("Processed reward for client. Reward: {Reward}", points);

        return points;
    }
}