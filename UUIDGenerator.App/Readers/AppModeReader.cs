using UUIDGenerator.App.Abstractions;

namespace UUIDGenerator.App.Readers;

/// <summary>
/// Application mode reader.
/// </summary>
public class AppModeReader
{
    private static readonly AppMode[] AppModes = Enum.GetValues<AppMode>();
    
    /// <summary>
    /// Read an app mode.
    /// </summary>
    /// <returns>App mode.</returns>
    public AppMode Read()
    {
        Console.WriteLine("Type down the application mode.");
        Console.WriteLine("Available modes is: {0}", string.Join(", ", AppModes));

        while (Console.ReadLine() is { } input && !string.IsNullOrEmpty(input))
        {
            if (Enum.TryParse<AppMode>(input, out var mode))
            {
                return mode;
            }
            
            Console.WriteLine("Incorrect application mode. Try again.");
        }
        
        throw new ApplicationException("Something went wrong.");
    }
}