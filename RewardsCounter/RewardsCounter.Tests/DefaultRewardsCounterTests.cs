using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RewardsCounter.Api.Configuration.Models;
using RewardsCounter.Api.Domain;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Services.Models;

namespace RewardsCounter.Tests;

[TestClass]
public class DefaultRewardsCounterTests
{
    private readonly ILogger<DefaultRewardsCounter> loggerMock = new NullLogger<DefaultRewardsCounter>(); 
    
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

        // Ivan
        new Transaction()
        {
            ClientId = Guid.Parse("99135b8d-cda6-493a-8994-6faecd21bf48"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
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
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
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
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
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
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },

        // Emma
        new Transaction()
        {
            ClientId = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b"),
            Id = Guid.NewGuid(),
            Sum = new decimal(12.3),
            Timestamp = new DateTime(2022, 6, 25),
        },
    };

    private readonly RewardsCountingConfiguration defaultRewardsRules = new()
    {
        Rewards = new List<RewardConfiguration>()
        {
            new RewardConfiguration()
            {
                Points = 1,
                Sum = new decimal(50)
            },
            new RewardConfiguration()
            {
                Points = 1,
                Sum = new decimal(100)
            }
        }

    };

        [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void CountReward_NullClient_NullException()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
#pragma warning disable CS8600
        Customer customer = null;
#pragma warning restore CS8600


        // act
#pragma warning disable CS8604
        service.CountReward(this.testTransactions, customer);
#pragma warning restore CS8604

        // assert
        // using attribute
    }
    
    [TestMethod]
    public void CountReward_120USD_90Points()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
        var customer = this.testCustomers[4];
        var expected = new decimal(90);

        // act
        var reward = service.CountReward(this.testTransactions, customer);

        // assert
        Assert.AreEqual(expected, reward.PointsTotal);
        Assert.AreEqual(customer,reward.Customer);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void CountReward_nullWithPeriod_NullException()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
#pragma warning disable CS8600
        Customer customer = null;
#pragma warning restore CS8600

        // act
#pragma warning disable CS8604
        service.CountReward(this.testTransactions, customer, new DateTime(2022, 7, 26), new DateTime(2022, 7, 28));
#pragma warning restore CS8604

        // assert
        // using attribute
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidRequestedPeriodException))]
    public void CountReward_WithInversePeriod_InvalidRequestedPeriodException()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
        var customer = this.testCustomers[4];

        // act
        service.CountReward(this.testTransactions, customer, new DateTime(2022, 7, 26), new DateTime(2022, 3, 28));

        // assert
        // using attribute
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidRequestedPeriodException))]
    public void CountReward_WithPeriodEarlyThenClientRegistered_InvalidRequestedPeriodException()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
        var customer = new Customer()
        {
            CreationDate = new DateTime(2023, 1, 12),
            Id = Guid.NewGuid(),
            Name = "Man from future"
        };

        // act
        service.CountReward(this.testTransactions, customer, new DateTime(2022, 7, 26), new DateTime(2022, 7, 28));

        // assert
        // using attribute
    }
    
    [TestMethod]
    public void CountReward_51USD_1Point()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
        var customer = this.testCustomers[2];
        var expected = new decimal(1);

        // act
        var reward = service.CountReward(this.testTransactions, customer,  new DateTime(2021, 2, 1),  new DateTime(2021, 2, 3));

        // assert
        Assert.AreEqual(expected, reward.PointsTotal);
        Assert.AreEqual(customer,reward.Customer);
    }
    
    [TestMethod]
    public void CountReward_Minus20USD_0Point()
    {
        // init
        var service = new DefaultRewardsCounter(this.defaultRewardsRules, this.loggerMock);
        var customer = new Customer()
        {
            CreationDate = new DateTime(2022, 7, 28),
            Id = Guid.Parse("41d9aa31-75c3-4df3-8563-375fb4be3b29"),
            Name = "Owner"
        };
        
        var expected = new decimal(0);
        var transaction = new Transaction()
        {
            Id = Guid.NewGuid(),
            ClientId = Guid.Parse("41d9aa31-75c3-4df3-8563-375fb4be3b29"),
            Sum = new decimal(-20),
            Timestamp = new DateTime(2022, 7, 29),
        };
        var transactions = new List<Transaction> {transaction};

        // act
        var reward = service.CountReward(transactions, customer);

        // assert
        Assert.AreEqual(expected, reward.PointsTotal);
        Assert.AreEqual(customer,reward.Customer);
    }
    
}