namespace UUIDGenerator.Tests;

/// <summary>
/// Tests for <see cref="Uuid"/>.
/// </summary>
public class UuidTests
{
    private readonly UuidV1Generator _uuidGenerator = new();
    
    [Fact]
    public void Uuid_Timestamp_Equality()
    {
        var date = DateTime.UtcNow;
        var uuid = _uuidGenerator.Generate(date);
        
        Assert.Equal(date, uuid.Timestamp);
    }

    [Fact]
    public void Uuid_BytesLength_Equality()
    {
        var date = DateTime.UtcNow;
        var uuid = _uuidGenerator.Generate(date);
        
        Assert.Equal(16, uuid.Bytes.Length);
    }

    [Fact]
    public void Uuid_Timestamp_ClockSequence_Node_BytesLength_Equality()
    {
        var date = DateTime.UtcNow;
        var uuid = _uuidGenerator.Generate(date);

        var timestamp = uuid.Bytes[..8];
        var clockSequence = uuid.Bytes[8..10];
        var node = uuid.Bytes[10..16];
        
        Assert.Equal(8, timestamp.Length);
        Assert.Equal(2, clockSequence.Length);
        Assert.Equal(6, node.Length);
    }
}