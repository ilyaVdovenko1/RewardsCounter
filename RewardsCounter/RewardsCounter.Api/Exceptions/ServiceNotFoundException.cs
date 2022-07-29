namespace RewardsCounter.Api.Exceptions;

/// <summary>
/// Throws when in di ca not find service.
/// </summary>
public class ServiceNotFoundException: ArgumentException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceNotFoundException"/> class.
    /// </summary>
    /// <param name="paramName">Name of parameter that init exception.</param>
    /// <param name="message">Exception message.</param>
    public ServiceNotFoundException(string paramName, string message)
        : base(message, paramName)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceNotFoundException"/> class.
    /// </summary>
    /// <param name="message">Exception message.</param>
    public ServiceNotFoundException(string message)
        : base(message)
    {
    }
}