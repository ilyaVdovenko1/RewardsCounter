namespace RewardsCounter.Api.Configuration.Models;

/// <summary>
/// Represents reward rules.
/// </summary>
public class RewardCountingConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RewardCountingConfiguration"/> class.
    /// </summary>
    /// <param name="rewards">Rewards rules.</param>
    public RewardCountingConfiguration(Dictionary<decimal, int> rewards)
    {
        this.Rewards = rewards ?? throw new ArgumentNullException(nameof(rewards));
    }

    /// <summary>
    /// Gets border of money where spend and bonus for it.
    /// </summary>
    /// <value>
    /// Border of money where spend and bonus for it.
    /// </value>
    public Dictionary<decimal, int> Rewards { get; }
}