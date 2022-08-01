using RewardsCounter.Api.Domain;

namespace RewardsCounter.Api.Services.Interfaces;

/// <summary>
/// Represents business logic service.
/// </summary>
public interface IAppService
{
    /// <summary>
    /// Provides concrete client.
    /// </summary>
    /// <param name="id">Client id.</param>
    /// <returns>Client.</returns>
    public Task<Customer> GetCustomer(Guid id);

    /// <summary>
    /// Provides transactions of concrete client.
    /// </summary>
    /// <param name="clientId">Client id.</param>
    /// <returns>Transactions for current client.</returns>
    public Task<IEnumerable<Transaction>> GetTransactions(Guid clientId);
}