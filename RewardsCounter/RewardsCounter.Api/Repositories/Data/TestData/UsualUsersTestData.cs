using RewardsCounter.Api.Repositories.Models;

namespace RewardsCounter.Api.Repositories.Data.TestData;

/// <summary>
/// Keeps normal users dataset for test purposes.
/// </summary>
public class UsualUsersTestData
{
    private readonly List<Customer> testCustomers = new ()
    {
        new Customer
        {
            Id = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            CreationDate = new DateTime(2018, 7, 28),
            Name = "Ilya",
        },
        new Customer
        {
            Id = Guid.Parse("99135b8d-cda6-493a-8994-6faecd21bf48"),
            CreationDate = new DateTime(2020, 7, 28),
            Name = "Ivan",
        },
        new Customer
        {
            Id = Guid.Parse("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
            CreationDate = new DateTime(2020, 7, 28),
            Name = "Ann",
        },
        new Customer
        {
            Id = Guid.Parse("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
            CreationDate = new DateTime(2019, 3, 12),
            Name = "John",
        },
        new Customer
        {
            Id = Guid.Parse("002f9c00-7523-44f1-ab9e-f906f368ab17"),
            CreationDate = new DateTime(2018, 2, 13),
            Name = "Liam",
        },
        new Customer
        {
            Id = Guid.Parse("ee884543-1b4e-46f9-a652-575aa9570f01"),
            CreationDate = new DateTime(2018, 3, 1),
            Name = "Olivia",
        },
        new Customer
        {
            Id = Guid.Parse("fa05b53c-da5e-4a30-9751-744afdcc5198"),
            CreationDate = new DateTime(2022, 1, 28),
            Name = "Oliver",
        },
        new Customer
        {
            Id = Guid.Parse("b5280851-7383-49d0-8375-e98f84e1ce3b"),
            CreationDate = new DateTime(2022, 7, 5),
            Name = "Amelia",
        },
        new Customer
        {
            Id = Guid.Parse("7203c9dd-6778-435e-8788-ce3532393fd0"),
            CreationDate = new DateTime(2021, 7, 28),
            Name = "Emma",
        },
    };

    /// <summary>
    /// Gets normal customers dataset for test purposes.
    /// </summary>
    /// <value>
    /// Normal customers dataset for test purposes.
    /// </value>
    public IEnumerable<Customer> TestCustomers => this.testCustomers;
}