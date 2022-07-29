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

    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultAppService"/> class.
    /// </summary>
    /// <param name="dataContext">Db accessor.</param>
    public DefaultAppService(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    /// <inheritdoc/>
    public async Task<Customer> GetCustomer(Guid id)
    {
        var customerDal = await this.dataContext.Customers.FirstOrDefaultAsync(item => item.Id == id).ConfigureAwait(false);
        if (customerDal is null)
        {
            throw new ClientNotFoundException($"Client with id {id} was not found.");
        }

        return new Customer()
        {
            CreationDate = customerDal.CreationDate,
            Id = customerDal.Id,
            Name = customerDal.Name,
        };
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Transaction>> GetTransactions(Guid clientId)
    {
        var transactions = await this.GetTransactions().ConfigureAwait(false);
        return transactions.Where(item => item.ClientId == clientId);
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