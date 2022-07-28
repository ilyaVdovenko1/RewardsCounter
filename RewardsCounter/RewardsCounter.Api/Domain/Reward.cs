namespace RewardsCounter.Api.Domain;

/// <summary>
/// Reward model.
/// </summary>
public class Reward
{
    /// <summary>
    /// Gets customer that earn reward.
    /// </summary>
    /// <value>
    /// Customer that earn reward.
    /// </value>
    public Customer Customer { get; init; }

    /// <summary>
    /// Gets total sum of points.
    /// </summary>
    /// <value>
    /// Total sum of points.
    /// </value>
    public decimal PointsTotal { get; init; }
}