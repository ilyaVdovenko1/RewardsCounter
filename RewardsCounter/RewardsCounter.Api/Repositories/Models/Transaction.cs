using System.ComponentModel.DataAnnotations.Schema;

namespace RewardsCounter.Api.Repositories.Models;

/// <summary>
/// Model of transaction.
/// </summary>
public class Transaction
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
    [Column(TypeName = "decimal(18,2)")]
    public decimal Sum { get; init; }

    /// <summary>
    /// Gets client id for current transaction.
    /// </summary>
    /// <value>
    /// Client id for current transaction.
    /// </value>
    public Guid ClientId { get; init; }
}