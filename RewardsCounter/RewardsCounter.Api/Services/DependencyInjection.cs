using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Repositories.Data;
using RewardsCounter.Api.Services.Interfaces;
using RewardsCounter.Api.Services.Models;

namespace RewardsCounter.Api.Services;

/// <summary>
/// DI functionality for app service.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Injects default app service.
    /// </summary>
    /// <param name="serviceCollection">DI Service collection.</param>
    /// <exception cref="ArgumentException">When can not find data context.</exception>
    public static void AddDefaultAppService(this IServiceCollection serviceCollection)
    {
        var serviceProvider = serviceCollection.BuildServiceProvider();
        var context = serviceProvider.GetService<DataContext>();
        if (context is null)
        {
            throw new ServiceNotFoundException("Can not recognize data context in service collection");
        }

        serviceCollection.AddSingleton<IAppService>(new DefaultAppService(context));
    }
}