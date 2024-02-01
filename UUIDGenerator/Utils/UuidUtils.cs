namespace UUIDGenerator.Utils;

/// <summary>
/// Utilities for <see cref="Uuid"/> management.
/// </summary>
public static class UuidUtils
{
    /// <summary>
    /// Extract UUID timestamp.
    /// </summary>
    /// <param name="bytes">UUID bytes.</param>
    /// <returns>Date time.</returns>
    public static DateTime ExtractTimestamp(byte[] bytes)
    {
        var timestamp = new byte[8];
        
        Array.Copy(bytes, UuidV1Constants.UuidTimestampOctet, timestamp, 0, 8);
        
        var ticks = BitConverter.ToInt64(timestamp, 0);

        ticks += UuidV1Constants.GregorianCalendarStart.Ticks;

        return new DateTimeOffset(ticks, TimeSpan.Zero).DateTime;
    }
}