namespace RewardsCounter.Api.Exceptions;

/// <summary>
/// Represents exception type when transactions was not found.
/// </summary>
public class TransactionsNotFoundException : ArgumentException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionsNotFoundException"/> class.
    /// </summary>
    /// <param name="paramName">Name of parameter that init exception.</param>
    /// <param name="message">Exception message.</param>
    public TransactionsNotFoundException(string paramName, string message)
        : base(message, paramName)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionsNotFoundException"/> class.
    /// </summary>
    /// <param name="message">Exception message.</param>
    public TransactionsNotFoundException(string message)
        : base(message)
    {
    }
}