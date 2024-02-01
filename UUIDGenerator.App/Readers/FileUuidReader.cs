namespace UUIDGenerator.App.Readers;

/// <summary>
/// File UUID reader.
/// </summary>
public class FileUuidReader
{
    /// <summary>
    /// Read file & print it.
    /// </summary>
    /// <param name="path">File path.</param>
    public IEnumerable<Uuid> Read(string path)
    {
        var lines = File.ReadAllLines(path);
        
        foreach (var line in lines)
        {
            var guid = Guid.Parse(line);
            var bytes = guid.ToByteArray();

            yield return new Uuid(bytes);
        }
    }
}