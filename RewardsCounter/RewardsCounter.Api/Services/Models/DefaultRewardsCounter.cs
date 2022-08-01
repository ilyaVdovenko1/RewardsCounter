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

        var clientTransactionsSum =
            transactions.Where(transaction => transaction.ClientId == customer.Id && transaction.Sum > 0).Sum(item => item.Sum);

        var fittingBonuses = this.countingConfiguration.Rewards.Where(rule => rule.Sum <= clientTransactionsSum);

        var points =
            fittingBonuses.Sum(fittingBonus => (clientTransactionsSum - fittingBonus.Sum) * fittingBonus.Points);

        this.logger?.LogTrace("Processed reward for client with id {Id}. Reward: {Reward}", customer.Id, points);

        return new Reward()
        {
            Customer = customer,
            PointsTotal = points,
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

        return this.CountReward(transactions.Where(item => item.Timestamp >= start && item.Timestamp <= end), customer);
    }
}