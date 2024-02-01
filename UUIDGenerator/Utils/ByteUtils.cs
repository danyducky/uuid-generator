namespace UUIDGenerator.Utils;

/// <summary>
/// Utilities for bytes management.
/// </summary>
internal static class ByteUtils
{
    private static readonly Random Random = new();
    
    /// <summary>
    /// Generates and fill the bytes array with random numbers.
    /// </summary>
    /// <param name="capacity">Byte array capacity.</param>
    /// <returns>Byte array.</returns>
    public static byte[] GenerateBytes(int capacity)
    {
        var node = new byte[capacity];
        
        Random.NextBytes(node);
        
        return node;
    }
}