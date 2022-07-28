using RewardsCounter.Api.Domain;

namespace RewardsCounter.Api.Services.Interfaces;

/// <summary>
/// Contract for counting rewards.
/// </summary>
public interface IRewardsCounter
{
    /// <summary>
    /// Counts reward through all transactions for concrete client.
    /// </summary>
    /// <param name="transactions">Transactions to process.</param>
    /// <param name="customer">Concrete client.</param>
    /// <returns>Reward.</returns>
    public Reward CountReward(IEnumerable<Transaction> transactions, Customer customer);

    /// <summary>
    /// Counts reward through transactions in {start; end} interval for concrete client.
    /// </summary>
    /// <param name="transactions">Transactions to process.</param>
    /// <param name="customer">Concrete client.</param>
    /// <param name="start">Start of processing period.</param>
    /// <param name="end">End of processing period.</param>
    /// <returns>Reward.</returns>
    public Reward CountReward(IEnumerable<Transaction> transactions, Customer customer, DateTime start, DateTime end);
}