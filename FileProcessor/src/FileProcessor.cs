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
}