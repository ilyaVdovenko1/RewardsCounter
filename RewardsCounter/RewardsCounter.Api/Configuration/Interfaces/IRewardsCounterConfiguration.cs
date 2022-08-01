using RewardsCounter.Api.Configuration.Models;

namespace RewardsCounter.Api.Configuration.Interfaces;

/// <summary>
/// Represents reward rules.
/// </summary>
public interface IRewardsCounterConfiguration
{
    /// <summary>
    /// Gets or sets border of money where spend and bonus for it.
    /// </summary>
    /// <value>
    /// Border of money where spend and bonus for it.
    /// </value>
    public List<RewardConfiguration> Rewards { get; set; }
}