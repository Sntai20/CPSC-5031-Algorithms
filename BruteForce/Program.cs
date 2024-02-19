// Read from contents from file(e.g. "CABAAXBYA")
// Pass file contents to CountVowels.
// Then output the number of CABAAXBYA found in the file.

class MainClass
{
    public static void Main(string[] args)
    {
        // Pass file contents to BruteForce and print results.
        BruteForce(ReadFromFile());

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    public static void BruteForce(string userInput)
    {
        // Convert userInput to lowercase.
        string lowerCase = userInput.ToLower();

        // Covert to string to array and store in arr variable.
        char[] characterArray = lowerCase.ToCharArray();

        // Find the searchString in userInput
        char searchStringStart = 'a';
        char searchStringEnd = 'b';

        int counterA = 0;
        int counterB = 0;
        Console.WriteLine($"\nSearching for {searchStringStart} and {searchStringEnd} in this string {lowerCase}");

        // Compare each character against the searchString array.
        for (int i = 0; i < characterArray.Length; i++)
        {
            // Evaluate if the userInput contains As.
            if (characterArray[i] == searchStringStart)
            {
                // Store the total number of As.
                counterA = counterA + 1;
            }

            // Evaluate if the userInput contains Bs.
            if (characterArray[i] == searchStringEnd)
            {
                // Store the total number of Bs.
                counterB = counterB + 1;
            }
        }

        Console.WriteLine($"A {counterA}");
        Console.WriteLine($"B {counterB}");
    }

    public static void CountInversion(string userInput)
    {
        // Convert userInput to lowercase.
        string lowerCase = userInput.ToLower();

        // Covert to string to array and store in arr variable.
        char[] characterArray = lowerCase.ToCharArray();

        // Find the searchString in userInput
        char searchString = 'n';

        int counterA = 0;
        Console.WriteLine($"\nSearching for {searchString} in this string {lowerCase}");

        // Compare each character against the searchString array.
        for (int i = 0; i < characterArray.Length; i++)
        {
            // Evaluate if the userInput contains As.
            if (characterArray[i] == searchString)
            {
                // Store the total number of As.
                counterA = counterA + 1;
            }
        }

        Console.WriteLine($"A {counterA}");
    }

    private static string ReadFromFile()
    {
        string fileName = "data.txt";
        string projectFolder = "BruteForce";
        string solutionFolderPath = "/Users/antonio/repo/CPSC-5031-Algorithms/";
        string fullFilePath = $"{solutionFolderPath}/{projectFolder}/{fileName}";

        // Read from contents from file(e.g. "CABAAXBYA")
        Console.Write($"Reading file {fullFilePath}");

        // Read text from text file and store in string.
        string text = File.ReadAllText(fullFilePath);

        // Pass the file contents to the BruteForce function.
        return text;
    }
}