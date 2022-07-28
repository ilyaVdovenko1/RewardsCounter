namespace RewardsCounter.Api.Domain;

/// <summary>
/// Model of transaction.
/// </summary>
public record Transaction
{
    /// <summary>
    /// Gets transaction id.
    /// </summary>
    /// <value>
    /// Transaction id.
    /// </value>
    public Guid Id { get; init; }

    /// <summary>
    /// Gets time when transaction happened.
    /// </summary>
    /// <value>
    /// Time when transaction happened.
    /// </value>
    public DateTime Timestamp { get; init; }

    /// <summary>
    /// Gets sum of transaction.
    /// </summary>
    /// <value>
    /// Sum of transaction.
    /// </value>
    public decimal Sum { get; init; }

    /// <summary>
    /// Gets client id for current transaction.
    /// </summary>
    /// <value>
    /// Client id for current transaction.
    /// </value>
    public Guid ClientId { get; init; }

}