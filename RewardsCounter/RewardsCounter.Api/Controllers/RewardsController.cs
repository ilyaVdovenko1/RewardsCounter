using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using RewardsCounter.Api.Dtos;
using RewardsCounter.Api.Exceptions;
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
    private readonly ILogger<RewardsController> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="RewardsController"/> class.
    /// </summary>
    /// <param name="rewardsCounterService">Counts reward.</param>
    /// <param name="appService">Main BLL service.</param>
    /// <param name="logger">Logger provider.</param>
    public RewardsController(IRewardsCounter rewardsCounterService, IAppService appService, ILogger<RewardsController> logger)
    {
        this.rewardsCounterService = rewardsCounterService;
        this.appService = appService;
        this.logger = logger;
    }

    /// <summary>
    /// Provides bonus count through all existing transactions.
    /// </summary>
    /// <param name="clientId">Client id.</param>
    /// <returns>Aggregated reward.</returns>
    [HttpGet("all")]
    public async Task<ActionResult<RewardDto>> GetAllRewards([Required]Guid clientId)
    {
        try
        {
            this.logger.LogInformation("Received user request.");

            var transactions = await this.appService.GetTransactions(clientId).ConfigureAwait(false);
            var client = await this.appService.GetCustomer(clientId).ConfigureAwait(false);

            var reward = this.rewardsCounterService.CountReward(transactions, client);
            this.logger.LogInformation("Sending answer for user request.");
            return this.Ok(new RewardDto()
            {
                CustomerName = reward.Customer.Name,
                PointsTotal = reward.PointsTotal,
            });
        }
        catch (InvalidRequestedPeriodException e)
        {
            this.logger.LogError(e, "Invalid period where requested");
            this.logger.LogInformation("Sending BadRequest code.");
            return this.BadRequest();
        }
        catch (ClientNotFoundException e)
        {
            this.logger.LogError(e, "Client was not found with this exception");
            this.logger.LogInformation("Sending 404 code.");
            return this.NotFound();
        }
        catch (TransactionsNotFoundException e)
        {
            this.logger.LogError(e, "Client transactions where not found with this exception");
            this.logger.LogInformation("Sending 404 code.");
            return this.NotFound();
        }
        catch (ArgumentNullException e)
        {
            this.logger.LogError(e, "Null exception");
            this.logger.LogInformation("Sending bad request code.");
            return this.BadRequest();
        }
        catch (ServiceNotFoundException e)
        {
            this.logger.LogError(e, "Some critical service was not found exception.");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
        catch (ArgumentException e)
        {
            this.logger.LogError(e, "ArgumentException");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
        catch (Exception e)
        {
            this.logger.LogError(e, "Some uncaught exception");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
    }

    /// <summary>
    /// Provides bonus count through last three month.
    /// </summary>
    /// <param name="clientId">Client id.</param>
    /// <returns>Aggregated reward.</returns>
    [HttpGet]
    public async Task<ActionResult<RewardDto>> GetRewardsPerLastThreeMonth([Required]Guid clientId)
    {
        try
        {
            this.logger.LogInformation("Received user request.");
            var transactions = await this.appService.GetTransactions(clientId).ConfigureAwait(false);
            var client = await this.appService.GetCustomer(clientId).ConfigureAwait(false);

            var reward =
                this.rewardsCounterService.CountReward(transactions, client, DateTime.Today.AddMonths(-3),
                    DateTime.Today);
            this.logger.LogInformation("Sending answer for user request.");
            return this.Ok(new RewardDto()
            {
                CustomerName = reward.Customer.Name,
                PointsTotal = reward.PointsTotal,
                MonthReward = reward.MonthReward,
            });
        }
        catch (InvalidRequestedPeriodException e)
        {
            this.logger.LogError(e, "Invalid period where requested");
            this.logger.LogInformation("Sending BadRequest code.");
            return this.BadRequest();
        }
        catch (ClientNotFoundException e)
        {
            this.logger.LogError(e, "Client was not found with this exception");
            this.logger.LogInformation("Sending 404 code.");
            return this.NotFound();
        }
        catch (TransactionsNotFoundException e)
        {
            this.logger.LogError(e, "Client transactions where not found with this exception");
            this.logger.LogInformation("Sending 404 code.");
            return this.NotFound();
        }
        catch (ArgumentNullException e)
        {
            this.logger.LogError(e, "Null exception");
            this.logger.LogInformation("Sending bad request code.");
            return this.BadRequest();
        }
        catch (ServiceNotFoundException e)
        {
            this.logger.LogError(e, "Some critical service was not found exception.");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
        catch (ArgumentException e)
        {
            this.logger.LogError(e, "ArgumentException");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
        catch (Exception e)
        {
            this.logger.LogError(e, "Some uncaught exception");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
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
        try
        {
            this.logger.LogInformation("Received user request.");
            var transactions = await this.appService.GetTransactions(clientId).ConfigureAwait(false);
            var client = await this.appService.GetCustomer(clientId).ConfigureAwait(false);

            var reward = this.rewardsCounterService.CountReward(transactions, client, start, end);
            this.logger.LogInformation("Received user request.");
            return this.Ok(new RewardDto()
            {
                CustomerName = reward.Customer.Name,
                PointsTotal = reward.PointsTotal,
            });
        }
        catch (InvalidRequestedPeriodException e)
        {
            this.logger.LogError(e, "Invalid period where requested");
            this.logger.LogInformation("Sending BadRequest code.");
            return this.BadRequest();
        }
        catch (ClientNotFoundException e)
        {
            this.logger.LogError(e, "Client was not found with this exception");
            this.logger.LogInformation("Sending 404 code.");
            return this.NotFound();
        }
        catch (TransactionsNotFoundException e)
        {
            this.logger.LogError(e, "Client transactions where not found with this exception");
            this.logger.LogInformation("Sending 404 code.");
            return this.NotFound();
        }
        catch (ArgumentNullException e)
        {
            this.logger.LogError(e, "Null exception");
            this.logger.LogInformation("Sending bad request code.");
            return this.BadRequest();
        }
        catch (ServiceNotFoundException e)
        {
            this.logger.LogError(e, "Some critical service was not found exception.");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
        catch (ArgumentException e)
        {
            this.logger.LogError(e, "ArgumentException");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
        catch (Exception e)
        {
            this.logger.LogError(e, "Some uncaught exception");
            this.logger.LogInformation("Sending 500 code.");
            return this.StatusCode(500);
        }
    }
}