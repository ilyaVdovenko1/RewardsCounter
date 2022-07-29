namespace RewardsCounter.Api.Configuration.Models;

/// <summary>
/// Represents reward rules.
/// </summary>
public class RewardsCountingConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RewardsCountingConfiguration"/> class.
    /// </summary>
#pragma warning disable CS8618
    public RewardsCountingConfiguration()
#pragma warning restore CS8618
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RewardsCountingConfiguration"/> class.
    /// </summary>
    /// <param name="rewards">Rewards rules.</param>
    public RewardsCountingConfiguration(IList<RewardConfiguration> rewards)
    {
        this.Rewards = new List<RewardConfiguration>(rewards);
    }

    /// <summary>
    /// Gets or sets border of money where spend and bonus for it.
    /// </summary>
    /// <value>
    /// Border of money where spend and bonus for it.
    /// </value>
    public List<RewardConfiguration> Rewards { get; set; }
}