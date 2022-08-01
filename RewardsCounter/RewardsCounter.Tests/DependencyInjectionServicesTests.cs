using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Repositories.Data;
using RewardsCounter.Api.Services;

namespace RewardsCounter.Tests;

[TestClass]
public class DependencyInjectionServicesTests
{
    [TestMethod]
    [ExpectedException(typeof(ServiceNotFoundException))]
    public void AddDefaultAppService_NoDataContext_ServiceNotFound()
    {
        //init
        var services = new ServiceCollection()
        {
        };
        
        //act
        services.AddDefaultAppService();
    }
    
    [TestMethod]
    public void AddDefaultAppService_DataContext()
    {
        //init
        var services = new ServiceCollection()
        {
        };

        services.AddDbContext<DataContext>();
        
        //act
        services.AddDefaultAppService();
        
    }
}