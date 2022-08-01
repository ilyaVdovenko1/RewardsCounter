using Microsoft.EntityFrameworkCore;
using RewardsCounter.Api.Configuration;
using RewardsCounter.Api.Configuration.Models;
using RewardsCounter.Api.Repositories.Data;
using RewardsCounter.Api.Services;
using RewardsCounter.Api.Services.Interfaces;
using RewardsCounter.Api.Services.Models;

const string counterOptionsName = "RewardCountingConfiguration";
const string healthCheckRoute = "api/health";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
var connectionString = ConfigureConnectionString(builder.Configuration);
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDefaultAppService();
builder.Services.AddHealthChecks()
    .AddSqlServer(connectionString, timeout: TimeSpan.FromSeconds(2));

var counterOpt = builder.Configuration.GetSection(counterOptionsName);
var rewardCountOpt = new RewardsCountingConfiguration();
counterOpt.Bind(rewardCountOpt);
builder.Services.AddSingleton<IRewardsCounter, DefaultRewardsCounter>(opt => new DefaultRewardsCounter(rewardCountOpt, opt.GetService<ILogger<DefaultRewardsCounter>>()));
var app = builder.Build();

app.Logger.LogTrace("Our connection string is: {ConnectionString}", connectionString);
app.UseSwagger();
app.UseSwaggerUI();

app.PreparePopulations();

app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks(healthCheckRoute);

try
{
    app.Logger.LogInformation("Starting app...");
    app.Run();
}
catch (Exception e)
{
    app.Logger.LogCritical(e, "App can not run properly.");
}

string ConfigureConnectionString(IConfiguration configurationManager)
{
    var server = configurationManager.GetSection("DbSettings:Server").Value ?? "localhost";
    var initialCatalog = configurationManager.GetSection("DbSettings:Initial Catalog").Value ?? "rewards-counter-db";
    var userName = configurationManager.GetSection("User ID").Value ?? string.Empty;
    var password = configurationManager.GetSection("Password").Value ?? string.Empty;

    return $"Server={server};Initial Catalog={initialCatalog};User ID={userName};Password={password};";
}