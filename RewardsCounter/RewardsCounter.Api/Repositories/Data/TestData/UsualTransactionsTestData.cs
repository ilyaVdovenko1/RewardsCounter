using RewardsCounter.Api.Repositories.Models;

namespace RewardsCounter.Api.Repositories.Data.TestData;

/// <summary>
/// Keeps test normal transactions dataset.
/// </summary>
public class UsualTransactionsTestData
{
    private readonly List<Transaction> testTransactions = new ()
    {
        // Ilya
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(1.3),
            Timestamp = new DateTime(2021, 2, 1),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2020, 2, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 7, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 6, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 5, 22),
        },

        // Ivan
        new Transaction()
        {
            ClientId = Guid.Parse("99135b8d-cda6-493a-8994-6faecd21bf48"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("99135b8d-cda6-493a-8994-6faecd21bf48"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 7, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("99135b8d-cda6-493a-8994-6faecd21bf48"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 6, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("99135b8d-cda6-493a-8994-6faecd21bf48"),
            Id = Guid.NewGuid(),
            Sum = new decimal(50),
            Timestamp = new DateTime(2022, 5, 22),
        },

        // Ann
        new Transaction()
        {
            ClientId = Guid.Parse("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(130),
            Timestamp = new DateTime(2021, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12),
            Timestamp = new DateTime(2021, 4, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("3b217a1d-c7d9-40da-a4d4-14e4c3a2ae2b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(51),
            Timestamp = new DateTime(2021, 2, 1),
        },

        // John
        new Transaction()
        {
            ClientId = Guid.Parse("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 7, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
            Id = Guid.NewGuid(),
            Sum = new decimal(50),
            Timestamp = new DateTime(2022, 3, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("de632b7e-627d-4bfe-9f96-edc290d32bbe"),
            Id = Guid.NewGuid(),
            Sum = new decimal(50),
            Timestamp = new DateTime(2022, 5, 22),
        },

        // Liam
        new Transaction()
        {
            ClientId = Guid.Parse("002f9c00-7523-44f1-ab9e-f906f368ab17"),
            Id = Guid.NewGuid(),
            Sum = new decimal(120),
            Timestamp = new DateTime(2022, 6, 25),
        },

        // Olivia
        new Transaction()
        {
            ClientId = Guid.Parse("fa05b53c-da5e-4a30-9751-744afdcc5198"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },

        // Oliver
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },

        // Amelia
        new Transaction()
        {
            ClientId = Guid.Parse("b5280851-7383-49d0-8375-e98f84e1ce3b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },

        // Emma
        new Transaction()
        {
            ClientId = Guid.Parse("7203c9dd-6778-435e-8788-ce3532393fd0"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("7203c9dd-6778-435e-8788-ce3532393fd0"),
            Id = Guid.NewGuid(),
            Sum = new decimal(40),
            Timestamp = new DateTime(2022, 7, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("7203c9dd-6778-435e-8788-ce3532393fd0"),
            Id = Guid.NewGuid(),
            Sum = new decimal(100),
            Timestamp = new DateTime(2022, 6, 22),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("7203c9dd-6778-435e-8788-ce3532393fd0"),
            Id = Guid.NewGuid(),
            Sum = new decimal(50),
            Timestamp = new DateTime(2022, 5, 22),
        },
    };

    /// <summary>
    /// Gets normal transactions data set.
    /// </summary>
    /// <value>
    /// Normal transactions data set.
    /// </value>
    public IEnumerable<Transaction> TestTransactions => this.testTransactions;
}