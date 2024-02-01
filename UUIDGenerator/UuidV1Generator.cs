using UUIDGenerator.Utils;
using UUIDGenerator.Validation;

namespace UUIDGenerator;

/// <summary>
/// UUID V1 generator.
/// </summary>
public class UuidV1Generator
{
    private readonly byte[] _nodeBytes;
    private readonly byte[] _clockSequence;

    /// <summary>
    /// Constructor.
    /// </summary>
    public UuidV1Generator()
    {
        _nodeBytes = ByteUtils.GenerateBytes(capacity: UuidV1Constants.UuidNodeBytesLength);
        _clockSequence = ByteUtils.GenerateBytes(capacity: UuidV1Constants.UuidClockSequenceLength);
    }

    /// <summary>
    /// Generates <see cref="Guid"/>.
    /// </summary>
    /// <param name="dateTime">Date time value.</param>
    /// <returns>Universally unique identifier.</returns>
    public Uuid Generate(DateTime dateTime)
    {
        Guard.ThrowIfNull(dateTime, "The time value is required.");

        var bytes = new byte[UuidV1Constants.UuidBytesLength];
        var ticks = dateTime.Ticks - UuidV1Constants.GregorianCalendarStart.Ticks;
        var timestamp = BitConverter.GetBytes(ticks);
        
        // Copy timestamp.
        Array.Copy(timestamp, 0, bytes, UuidV1Constants.UuidTimestampOctet, Math.Min(8, timestamp.Length));
        
        // Copy clock sequence.
        Array.Copy(_clockSequence, 0, bytes, UuidV1Constants.UuidClockSequenceOctet, Math.Min(2, _clockSequence.Length));

        // Copy node bytes.
        Array.Copy(_nodeBytes, 0, bytes, UuidV1Constants.UuidNodeOctet, Math.Min(6, _nodeBytes.Length));

        return new Uuid(bytes);
    }
}