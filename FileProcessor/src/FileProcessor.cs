using System.Security.Cryptography;
using System.Text;

namespace FileProcessor;

public class FileProcessor
{
    public static int ProcessData(string pathToFile)
    {
        Console.Write($"Reading file {pathToFile}");

        var listOfItems = File.ReadAllLines(pathToFile)
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(tokens => new
            {
                Item = tokens,
                Message = tokens,
                ElapsedTime = tokens,
                ExpectedFilePathMessage = tokens
            });

        int fileProcessedCount = 0;
        foreach (var item in listOfItems)
        {
            if (item.Item[0] == "#EOF")
            {
                Console.WriteLine("End of file");
                return fileProcessedCount;
            }
            fileProcessedCount++;
        }

        return fileProcessedCount;
    }

    public static string GetSHA256HashFromFile(string fileName)
    {
        using FileStream file = new(fileName, FileMode.Open);
        SHA256 sha256 = SHA256.Create();
        byte[] hashBytes = sha256.ComputeHash(file);

        // Convert the hash bytes to a hexadecimal string.
        StringBuilder sb = new();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }
}