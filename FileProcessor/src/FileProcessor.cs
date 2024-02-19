namespace FileProcessor;

public class FileProcessor
{
    public static int ProcessData(string fullFilePath)
    {
        // Read text from csv file and store in string.
        Console.Write($"Reading file {fullFilePath}");

        var listOfItems = File.ReadAllLines(fullFilePath)
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(tokens => new
            {
                Item = tokens,
                Message = tokens,
                ElapsedTime = tokens,
                ExpectedFilePathMessage = tokens
            });

        foreach (var item in listOfItems)
        {
            if (item.Item[0] == "#EOF")
            {
                return 0;
            }
        }

        return 1;
    }
}