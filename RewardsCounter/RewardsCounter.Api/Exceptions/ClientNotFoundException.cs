namespace RewardsCounter.Api.Exceptions;

/// <summary>
/// Represents exception type when user was not found.
/// </summary>
public class ClientNotFoundException : ArgumentException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientNotFoundException"/> class.
    /// </summary>
    /// <param name="paramName">Name of parameter that init exception.</param>
    /// <param name="message">Exception message.</param>
    public ClientNotFoundException(string paramName, string message)
        : base(message, paramName)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientNotFoundException"/> class.
    /// </summary>
    /// <param name="message">Exception message.</param>
    public ClientNotFoundException(string message)
        : base(message)
    {
    }
}