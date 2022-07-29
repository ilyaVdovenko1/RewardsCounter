using Microsoft.EntityFrameworkCore;
using RewardsCounter.Api.Configuration.Models;
using RewardsCounter.Api.Repositories.Data;
using RewardsCounter.Api.Services;
using RewardsCounter.Api.Services.Interfaces;
using RewardsCounter.Api.Services.Models;

const string connectionStringName = "DefaultConnectionString";
const string counterOptionsName = "RewardCountingConfiguration";
const string healthCheckRoute = "api/health";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString(connectionStringName);
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

builder.Services.AddSingleton<IRewardsCounter>(new DefaultRewardsCounter(rewardCountOpt));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks(healthCheckRoute);

app.Run();