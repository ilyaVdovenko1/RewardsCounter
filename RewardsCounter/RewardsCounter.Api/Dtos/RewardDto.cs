using RewardsCounter.Api.Domain;

namespace RewardsCounter.Api.Dtos;

/// <summary>
/// Reward model.
/// </summary>
public class RewardDto
{
    /// <summary>
    /// Gets customer that earn reward.
    /// </summary>
    /// <value>
    /// Customer that earn reward.
    /// </value>
    public string CustomerName { get; init; } = null!;

    /// <summary>
    /// Gets total sum of points.
    /// </summary>
    /// <value>
    /// Total sum of points.
    /// </value>
    public decimal PointsTotal { get; init; }
}