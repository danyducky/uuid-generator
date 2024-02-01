namespace UUIDGenerator.Validation;

/// <summary>
/// Validation guard.
/// </summary>
internal static class Guard
{
    /// <summary>
    /// Throws an exception if value is null.
    /// </summary>
    /// <param name="value">Value to be validated.</param>
    /// <param name="message">Validation message.</param>
    /// <typeparam name="T">Value type.</typeparam>
    /// <exception cref="ArgumentOutOfRangeException">Exception to be thrown if null.</exception>
    public static void ThrowIfNull<T>(T value, string message)
    {
        if (value == null) throw new ArgumentOutOfRangeException(nameof(T), message);
    }
}