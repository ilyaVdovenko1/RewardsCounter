namespace RewardsCounter.Api.Configuration.Models;

/// <summary>
/// Represents one unit of rewarding.
/// </summary>
public class RewardConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RewardConfiguration"/> class.
    /// </summary>
    public RewardConfiguration()
    {
    }

    /// <summary>
    /// Gets or sets the amount for which the reward is charged.
    /// </summary>
    /// <value>
    /// The amount for which the reward is charged.
    /// </value>
    public decimal Sum { get; set; }

    /// <summary>
    /// Gets or sets the amount of bonus.
    /// </summary>
    /// <value>
    /// The amount of bonus.
    /// </value>
    public int Points { get; set; }
}