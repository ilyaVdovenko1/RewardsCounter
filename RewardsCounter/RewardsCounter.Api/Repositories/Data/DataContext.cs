using Microsoft.EntityFrameworkCore;
using RewardsCounter.Api.Repositories.Data.TestData;
using RewardsCounter.Api.Repositories.Models;

namespace RewardsCounter.Api.Repositories.Data;

/// <summary>
/// Represents all data we need from database.
/// </summary>
public class DataContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataContext"/> class.
    /// </summary>
    /// <param name="contextOptions">Options for data context.</param>
    public DataContext(DbContextOptions<DataContext> contextOptions)
        : base(contextOptions)
    {
    }

    /// <summary>
    /// Gets or sets set of transactions from db.
    /// </summary>
    /// <value>
    /// Set of transactions from db.
    /// </value>
    public DbSet<Transaction> Transactions { get; set; }

    /// <summary>
    /// Gets or sets set of clients from db.
    /// </summary>
    /// <value>
    /// Set of clients from db.
    /// </value>
    public DbSet<Customer> Customers { get; set; }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
        {
            throw new ArgumentNullException(nameof(modelBuilder));
        }

        var testTransactions = new UsualTransactionsTestData().TestTransactions;
        modelBuilder.Entity<Transaction>().Property(p => p.Sum).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<Transaction>().HasData(testTransactions);

        var testUsers = new UsualUsersTestData().TestCustomers;
        modelBuilder.Entity<Customer>().HasData(testUsers);
    }
}