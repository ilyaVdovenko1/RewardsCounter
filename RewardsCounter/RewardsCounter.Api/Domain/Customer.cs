namespace RewardsCounter.Api.Domain;

/// <summary>
/// Model that represents client.
/// </summary>
public record Customer
{
    /// <summary>
    /// Gets client id.
    /// </summary>
    /// <value>
    /// Client id.
    /// </value>
    public Guid Id { get; init; }

    /// <summary>
    /// Gets client name.
    /// </summary>
    /// <value>
    /// Client name.
    /// </value>
    public string Name { get; init; } = null!;

    /// <summary>
    /// Gets time client sign up.
    /// </summary>
    /// <value>
    /// Time client sign up.
    /// </value>
    public DateTime CreationDate { get; init; }
};