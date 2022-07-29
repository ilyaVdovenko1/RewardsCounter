using Microsoft.EntityFrameworkCore;
using RewardsCounter.Api.Configuration.Models;
using RewardsCounter.Api.Repositories.Data;
using RewardsCounter.Api.Services;
using RewardsCounter.Api.Services.Interfaces;
using RewardsCounter.Api.Services.Models;

const string connectionStringName = "DefaultConnectionString";
const string counterOptionsName = "RewardCountingConfiguration";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(connectionStringName));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDefaultAppService();

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

app.Run();