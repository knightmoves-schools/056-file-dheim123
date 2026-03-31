using System.IO;

namespace knightmoves;

public class FileManager
{
    public void Create(string fileName)
    {
        string directory = Path.GetDirectoryName(fileName);
        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        File.WriteAllText(fileName, "hello file");
    }
}
