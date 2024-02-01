namespace UUIDGenerator;

/// <summary>
/// Contains UUID V1 constants.
/// </summary>
internal static class UuidV1Constants
{
    /// <summary>
    /// UUID is 128 bits longs.
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-1
    /// </summary>
    public const int UuidBytesLength = 16;

    /// <summary>
    /// Nodes length is 48 bits long.
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.2
    /// </summary>
    public const int UuidNodeBytesLength = 6;

    /// <summary>
    /// `clock_seq_hi_and_reserved` and `clock_seq_low` are 16 bits long.
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.2
    /// </summary>
    public const int UuidClockSequenceLength = 2;

    /// <summary>
    /// UUID array octet of a timestamp.
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.2
    /// </summary>
    public const int UuidTimestampOctet = 0;

    /// <summary>
    /// UUID array octet of a clock sequence.
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.2
    /// </summary>
    public const int UuidClockSequenceOctet = 8;

    /// <summary>
    /// UUID array octet of a node.
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.2
    /// </summary>
    public const int UuidNodeOctet = 10;
    
    /// <summary>
    /// Offset to move from 1/1/0001, which is 0-time for .NET, to gregorian 0-time of 10/15/1582
    /// https://datatracker.ietf.org/doc/html/rfc4122#section-4.1.4
    /// </summary>
    public static readonly DateTimeOffset GregorianCalendarStart 
        = new(
            year: 1582, 
            month: 10, 
            day: 15, 
            hour: 0, 
            minute: 0, 
            second: 0, 
            offset: TimeSpan.Zero);
}