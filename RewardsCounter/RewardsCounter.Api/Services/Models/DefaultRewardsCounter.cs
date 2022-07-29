using RewardsCounter.Api.Configuration.Models;
using RewardsCounter.Api.Domain;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Services.Interfaces;

namespace RewardsCounter.Api.Services.Models;

/// <summary>
/// Implements default logic of counting reward.
/// </summary>
public class DefaultRewardsCounter : IRewardsCounter
{
    private readonly RewardsCountingConfiguration countingConfiguration;

    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultRewardsCounter"/> class.
    /// </summary>
    /// <param name="countingConfiguration">Represents reward rules.</param>
    public DefaultRewardsCounter(RewardsCountingConfiguration countingConfiguration)
    {
        this.countingConfiguration = countingConfiguration;
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
            throw new ArgumentNullException(nameof(customer));
        }

        var clientTransactionsSum =
            transactions.Where(transaction => transaction.ClientId == customer.Id && transaction.Sum > 0).Sum(item => item.Sum);

        var fittingBonuses = this.countingConfiguration.Rewards.Where(rule => rule.Sum <= clientTransactionsSum);

        var points =
            fittingBonuses.Sum(fittingBonus => (clientTransactionsSum - fittingBonus.Sum) * fittingBonus.Points);

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
            throw new ArgumentNullException(nameof(customer));
        }

        if (start > end)
        {
            throw new InvalidRequestedPeriodException(nameof(start), "Start value in period can not be less then end.");
        }

        if (start < customer.CreationDate)
        {
            throw new InvalidRequestedPeriodException(nameof(start), "Start value can not be greater then customer registration date.");
        }

        return this.CountReward(transactions.Where(item => item.Timestamp >= start && item.Timestamp <= end), customer);
    }
}