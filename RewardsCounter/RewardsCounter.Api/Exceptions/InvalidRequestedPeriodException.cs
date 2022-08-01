namespace RewardsCounter.Api.Exceptions;

/// <summary>
/// Represents exception when data period where messed up.
/// </summary>
public class InvalidRequestedPeriodException : ArgumentOutOfRangeException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidRequestedPeriodException"/> class.
    /// </summary>
    /// <param name="parameter">The name of the parameter that causes this exception.</param>
    /// <param name="message">Exception message.</param>
    public InvalidRequestedPeriodException(string parameter, string message)
        : base(parameter, message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidRequestedPeriodException"/> class.
    /// </summary>
    /// <param name="message">Exception message.</param>
    public InvalidRequestedPeriodException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidRequestedPeriodException"/> class.
    /// </summary>
    public InvalidRequestedPeriodException()
    {
    }
}