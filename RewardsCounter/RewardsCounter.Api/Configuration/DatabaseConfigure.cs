using Microsoft.EntityFrameworkCore;
using RewardsCounter.Api.Exceptions;
using RewardsCounter.Api.Repositories.Data;

namespace RewardsCounter.Api.Configuration;

/// <summary>
/// Configure database.
/// </summary>
public static class DatabaseConfigure
{
    /// <summary>
    /// Adds migrations.
    /// </summary>
    /// <param name="app">App.</param>
    /// <exception cref="ServiceNotFoundException">When data context did not found.</exception>
    public static void PreparePopulations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        Migrate(scope.ServiceProvider.GetService<DataContext>() ?? throw new ServiceNotFoundException("Data scope was not found."));
    }

    private static void Migrate(DataContext context)
    {
        context.Database.Migrate();
    }
}