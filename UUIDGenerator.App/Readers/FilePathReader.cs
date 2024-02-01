namespace UUIDGenerator.App.Readers;

/// <summary>
/// Reads the file path.
/// </summary>
public class FilePathReader
{
    /// <summary>
    /// Read file path.
    /// </summary>
    /// <returns>File path.</returns>
    public string Read()
    {
        Console.WriteLine("Input your file path to save/read UUID's.");
        Console.WriteLine("It can be absolute or relative path.");
        
        while (Console.ReadLine() is { } input && !string.IsNullOrEmpty(input))
        {
            return input;
        }

        throw new ApplicationException("Something went wrong.");
    }
}