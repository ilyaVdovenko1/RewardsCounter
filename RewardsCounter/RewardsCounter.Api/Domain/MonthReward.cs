namespace RewardsCounter.Api.Domain;

/// <summary>
/// Reward per month.
/// </summary>
public class MonthReward
{
    /// <summary>
    /// Gets month number.
    /// </summary>
    public int Month { get; init; }

    /// <summary>
    /// Gets year number.
    /// </summary>
    public int Year { get; init; }

    /// <summary>
    /// gets bonus sum.
    /// </summary>
    public decimal Bonus { get; init; }
}