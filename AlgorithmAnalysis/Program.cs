// Read from contents from file(e.g. "Welcome to SeattleU!")
// Pass file contents to CountVowels.
// Then output the number of vowels found in the file.

class MainClass
{
    public static void Main(string[] args)
    {
        // Pass file contents to CountVowels and print results.
        var numberOfVowels = CountVowels(ReadFromFile());
        Console.WriteLine($"{numberOfVowels} : Total number of vowels found in the file.");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    public static int CountVowels(string userInput)
    {
        // Convert userInput to lowercase.
        string lowerCase = userInput.ToLower();

        // Covert to string to array and store in arr variable.
        char[] characterArray = lowerCase.ToCharArray();

        // Find the vowels in userInput
        string vowelString = "aeiouy";
        char[] vowels = vowelString.ToCharArray();

        int counter = 0;
        Console.WriteLine($"\nSearching for {vowelString} in this string {lowerCase}");

        // Compare each character against the vowels array.
        for (int i = 0; i < characterArray.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                // Evaluate if the userInput contains vowels.
                if (characterArray[i] == vowels[j])
                {
                    // Store the total number of vowels.
                    counter++;
                }
            }
        }

        return counter;
    }

    private static string ReadFromFile()
    {
        string fileName = "data.txt";
        string projectFolder = "AlgorithmAnalysis";
        string solutionFolderPath = "/Users/antonio/repo/CPSC-5031-Algorithms/";
        string fullFilePath = $"{solutionFolderPath}/{projectFolder}/{fileName}";

        // Read from contents from file(e.g. "Welcome to SeattleU!")
        Console.Write($"Reading file {fullFilePath}");

        // Read text from text file and store in string.
        string text = File.ReadAllText(fullFilePath);

        // Pass the file contents to the CountVowels function.
        return text;
    }
}