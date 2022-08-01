using Microsoft.EntityFrameworkCore;
using RewardsCounter.Api.Domain;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Repositories.Data;
using RewardsCounter.Api.Services.Interfaces;

namespace RewardsCounter.Api.Services.Models;

/// <inheritdoc />
public class DefaultAppService : IAppService
{
    private readonly DataContext dataContext;
    private readonly ILogger<DefaultAppService> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultAppService"/> class.
    /// </summary>
    /// <param name="dataContext">Db accessor.</param>
    /// <param name="logger">Logging provider.</param>
    public DefaultAppService(DataContext dataContext, ILogger<DefaultAppService> logger)
    {
        this.dataContext = dataContext;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task<Customer> GetCustomer(Guid id)
    {
        this.logger.LogInformation("Requested customer with id {Id}", id);
        var customer = await this.dataContext.Customers.FirstOrDefaultAsync(item => item.Id == id).ConfigureAwait(false);
        if (customer is null)
        {
            this.logger.LogWarning("Client with id {Id} was not found.", id);
            throw new ClientNotFoundException($"Client with id {id} was not found.");
        }

        this.logger.LogTrace("Returning customer...");
        return new Customer()
        {
            CreationDate = customer.CreationDate,
            Id = customer.Id,
            Name = customer.Name,
        };
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Transaction>> GetTransactions(Guid clientId)
    {
        this.logger.LogInformation("Requested all transactions for client with {ClientId}", clientId);
        var transactions = await this.GetTransactions().ConfigureAwait(false);
        var fittingTransactions = transactions.Where(item => item.ClientId == clientId).ToList();
        if (fittingTransactions.ToList().Count == 0)
        {
            this.logger.LogWarning("Client transactions with id {ClientId} was not found.", clientId);
            throw new TransactionsNotFoundException($"Transactions for client with this id {clientId} was not found");
        }

        return fittingTransactions;
    }

    private async Task<IEnumerable<Transaction>> GetTransactions()
    {
        var transactionsDal = await this.dataContext.Transactions.ToListAsync().ConfigureAwait(false);
        var transactions = transactionsDal.Select(transactionDal => new Transaction()
            {
                ClientId = transactionDal.ClientId, Id = transactionDal.Id, Sum = transactionDal.Sum, Timestamp = transactionDal.Timestamp,
            })
            .ToList();
        return transactions;
    }
}