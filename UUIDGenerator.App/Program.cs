using UUIDGenerator.App.Abstractions;
using UUIDGenerator.App.Readers;
using UUIDGenerator.App.Utils;

namespace UUIDGenerator.App;

/// <summary>
/// Start point.
/// </summary>
class Program
{
    private static readonly AppModeReader AppModeReader = new();
    private static readonly FilePathReader FilePathReader = new();
    private static readonly DatesReader DatesReader = new();
    private static readonly DateReader DateReader = new();
    private static readonly FileUuidReader UuidReader = new();
    private static readonly UuidV1Generator UuidGenerator = new();
    
    /// <summary>
    /// Main point.
    /// </summary>
    /// <param name="args">App args.</param>
    static void Main(string[] args)
    {
        var filePath = FilePathReader.Read();
        var mode = AppModeReader.Read();
        
        switch (mode)
        {
            case AppMode.Read:
                RunReadMode(filePath);
                break;
            case AppMode.Write:
                RunWriteMode(filePath);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(AppMode), "Unsupported application mode.");
        }
    }

    private static void RunReadMode(string filePath)
    {
        var date = DateReader.Read();
        var uuids = UuidReader
            .Read(filePath)
            .Where(uuid => uuid.Timestamp == date);
        
        foreach (var uuid in uuids)
        {
            Console.WriteLine(uuid);
        }
    }

    private static void RunWriteMode(string filePath)
    {
        var uuids = DatesReader
            .Read()
            .Select(UuidGenerator.Generate);

        FileUtils.CreateIfNotExists(filePath);
        
        using var writer = File.AppendText(filePath);

        foreach (var uuid in uuids)
        {
            writer.WriteLine(uuid);
        }

        writer.Close();
    }
}