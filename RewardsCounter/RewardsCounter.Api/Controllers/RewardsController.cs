using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using RewardsCounter.Api.Dtos;
using RewardsCounter.Api.Services.Interfaces;

namespace RewardsCounter.Api.Controllers;

/// <summary>
/// This controller is access point for rewards count.
/// </summary>
[ApiController]
[Route("api/[controller]/rewards")]
public class RewardsController : ControllerBase
{
    private readonly IRewardsCounter rewardsCounterService;
    private readonly IAppService appService;

    /// <summary>
    /// Initializes a new instance of the <see cref="RewardsController"/> class.
    /// </summary>
    /// <param name="rewardsCounterService">Counts reward.</param>
    /// <param name="appService">Main BLL service.</param>
    public RewardsController(IRewardsCounter rewardsCounterService, IAppService appService)
    {
        this.rewardsCounterService = rewardsCounterService;
        this.appService = appService;
    }

    /// <summary>
    /// Provides bonus count through all existing transactions.
    /// </summary>
    /// <param name="clientId">Client id.</param>
    /// <returns>Aggregated reward.</returns>
    [HttpGet("all")]
    public async Task<ActionResult<RewardDto>> GetAllRewards([Required]Guid clientId)
    {
        var transactions = await this.appService.GetTransactions(clientId).ConfigureAwait(false);
        var client = await this.appService.GetCustomer(clientId).ConfigureAwait(false);

        var reward = this.rewardsCounterService.CountReward(transactions, client);
        return this.Ok(new RewardDto()
        {
            CustomerName = reward.Customer.Name,
            PointsTotal = reward.PointsTotal,
        });
    }

    /// <summary>
    /// Provides bonus count through last three month.
    /// </summary>
    /// <param name="clientId">Client id.</param>
    /// <returns>Aggregated reward.</returns>
    [HttpGet]
    public async Task<ActionResult<RewardDto>> GetRewardsPerLastThreeMonth([Required]Guid clientId)
    {
        var transactions = await this.appService.GetTransactions(clientId).ConfigureAwait(false);
        var client = await this.appService.GetCustomer(clientId).ConfigureAwait(false);

        var reward = this.rewardsCounterService.CountReward(transactions, client, DateTime.Today.AddMonths(-3), DateTime.Today);
        return this.Ok(new RewardDto()
        {
            CustomerName = reward.Customer.Name,
            PointsTotal = reward.PointsTotal,
        });
    }

    /// <summary>
    /// Provides bonus count through period.
    /// </summary>
    /// <param name="clientId">Client id.</param>
    /// <param name="start">Start of period.</param>
    /// <param name="end">End of period.</param>
    /// <returns>Aggregated reward.</returns>
    [HttpGet("per")]
    public async Task<ActionResult<RewardDto>> GetRewardsAtPeriod([Required]Guid clientId, [Required]DateTime start, [Required]DateTime end)
    {
        var transactions = await this.appService.GetTransactions(clientId).ConfigureAwait(false);
        var client = await this.appService.GetCustomer(clientId).ConfigureAwait(false);

        var reward = this.rewardsCounterService.CountReward(transactions, client, start, end);
        return this.Ok(new RewardDto()
        {
            CustomerName = reward.Customer.Name,
            PointsTotal = reward.PointsTotal,
        });
    }
}