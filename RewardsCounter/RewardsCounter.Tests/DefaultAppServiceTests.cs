using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockQueryable.Moq;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Repositories.Data;
using Moq;
using RewardsCounter.Api.Repositories.Models;
using RewardsCounter.Api.Services.Models;

namespace RewardsCounter.Tests;

[TestClass]
public class DefaultAppServiceTests
{
    private readonly ILogger<DefaultAppService> loggerMock = new NullLogger<DefaultAppService>(); 
    private readonly List<Customer> testCustomers = new()
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

    private readonly List<Transaction> testTransactions = new()
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

    

    
    [ExpectedException(typeof(ClientNotFoundException))]
    [TestMethod]
    public async Task GetCustomer_UnexistingId_ClientNotFound()
    {
        // init
        var dataContextMoq = new Mock<DataContext>();

        var clientsDataSetMock = this.testCustomers.AsQueryable().BuildMockDbSet();
        
        
        dataContextMoq.Setup(t => t.Customers).Returns(clientsDataSetMock.Object);
        
        var service = new DefaultAppService(dataContextMoq.Object, this.loggerMock);
        var fakeId = Guid.NewGuid();

        // act
        var customer =  await service.GetCustomer(fakeId);

        // assert
        // using attribute

    }

    [TestMethod]
    public async Task GetCustomer_ExistingId_ClientFound()
    {
        // init
        var dataContextMoq = new Mock<DataContext>();

        var clientsDataSetMock = this.testCustomers.AsQueryable().BuildMockDbSet();
        
        
        dataContextMoq.Setup(t => t.Customers).Returns(clientsDataSetMock.Object);
        
        var service = new DefaultAppService(dataContextMoq.Object, this.loggerMock);
        var expectedCustomer = new Api.Domain.Customer()
        {
            CreationDate = this.testCustomers[0].CreationDate,
            Id = this.testCustomers[0].Id,
            Name = this.testCustomers[0].Name,
        };
        
        var id = expectedCustomer.Id;

        // act
        var customer =  await service.GetCustomer(id);

        // assert
        Assert.AreEqual(expectedCustomer, customer);

    }
    
    [TestMethod]
    [ExpectedException(typeof(TransactionsNotFoundException))]
    public async Task GetTransactions_UnexistingClientId_TransactionsNotFound()
    {
        // init
        var dataContextMoq = new Mock<DataContext>();

        var transactionsDataSetMock = this.testTransactions.AsQueryable().BuildMockDbSet();
        
        
        dataContextMoq.Setup(t => t.Transactions).Returns(transactionsDataSetMock.Object);
        
        var service = new DefaultAppService(dataContextMoq.Object, this.loggerMock);

        var id = Guid.NewGuid();

        // act
        await service.GetTransactions(id);

        // assert
        // using attribute

    }
    
    [TestMethod]
    public async Task GetTransactions_ExistingClientId_TransactionsFound()
    {
        // init
        var dataContextMoq = new Mock<DataContext>();

        var transactionsDataSetMock = this.testTransactions.AsQueryable().BuildMockDbSet();
        
        
        dataContextMoq.Setup(t => t.Transactions).Returns(transactionsDataSetMock.Object);
        
        var service = new DefaultAppService(dataContextMoq.Object, this.loggerMock);

        var id = Guid.Parse("b96c7e78-46bd-4057-8990-e3d2f82e0e8b");
        var expectedTransactions = this.testTransactions.Select(t => new Api.Domain.Transaction()
        {
            ClientId = t.ClientId,
            Id = t.Id,
            Sum = t.Sum,
            Timestamp = t.Timestamp
        }).Where(t => t.ClientId == id);

        

        // act
        var actualTransactions = await service.GetTransactions(id);
        

        // assert
        CollectionAssert.AreEqual(expectedTransactions.ToList(), actualTransactions.ToList());

    }
    
    
}