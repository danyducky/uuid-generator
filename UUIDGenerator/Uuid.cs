using UUIDGenerator.Utils;
using UUIDGenerator.Validation;

namespace UUIDGenerator;

/// <summary>
/// Universally unique identifier.
/// 128-bit number used to identify objects.
/// https://datatracker.ietf.org/doc/html/rfc4122
/// </summary>
public readonly struct Uuid
{
    private readonly Guid _guid;
    
    /// <summary>
    /// Gets the timestamp.
    /// </summary>
    public DateTime Timestamp { get; }
    
    /// <summary>
    /// Gets the UUID bytes.
    /// </summary>
    public byte[] Bytes { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="bytes">UUID bytes.</param>
    public Uuid(byte[] bytes)
    {
        Guard.ThrowIfNull(bytes, "Bytes array must be defined.");
        
        _guid = new Guid(bytes);

        Bytes = bytes;
        Timestamp = UuidUtils.ExtractTimestamp(bytes);
    }

    /// <inheritdoc />
    public override string ToString() => _guid.ToString();
}