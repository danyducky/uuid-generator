namespace UUIDGenerator.App.Readers;

/// <summary>
/// Console date reader.
/// </summary>
public class DateReader
{
    /// <summary>
    /// Read a date.
    /// </summary>
    /// <returns>Date.</returns>
    public DateTime Read()
    {
        Console.WriteLine("Input source date to list matching UUIDs: ");
        
        while (Console.ReadLine() is { } input && !string.IsNullOrEmpty(input))
        {
            if (DateTime.TryParse(input, out var dateTime))
            {
                return dateTime;
            }
        }
        
        throw new ApplicationException("Something went wrong.");
    }
}