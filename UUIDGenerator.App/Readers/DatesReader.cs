namespace UUIDGenerator.App.Readers;

/// <summary>
/// Console dates reader.
/// </summary>
public class DatesReader
{
    private const string QuitKeyword = "Quit";

    /// <summary>
    /// Read dates.
    /// </summary>
    /// <returns>Dates.</returns>
    public IEnumerable<DateTime> Read()
    {
        Console.WriteLine("Input any date time. Format: [dd.mm.yyyy].");
        Console.WriteLine("Type `{0}` keyword to quit & save it.", QuitKeyword);
        
        while (Console.ReadLine() is { } input && !string.IsNullOrEmpty(input))
        {
            if (input == QuitKeyword)
            {
                yield break;
            }
            
            if (DateTime.TryParse(input, out var dateTime))
            {
                yield return dateTime;
            }
            else
            {
                Console.WriteLine("Incorrect data format. Try again.");
            }
        }
    }
}