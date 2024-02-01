namespace UUIDGenerator.App.Utils;

/// <summary>
/// Utilities for files management.
/// </summary>
public static class FileUtils
{
    /// <summary>
    /// Get or create file.
    /// </summary>
    /// <param name="path">File path.</param>
    /// <returns>File stream.</returns>
    public static void CreateIfNotExists(string path)
    {
        if (!File.Exists(path))
        {
            using var fs = File.Create(path);
        }
    }
}