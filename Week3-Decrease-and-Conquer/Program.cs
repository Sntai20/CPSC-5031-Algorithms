// Read from contents from file(e.g. "CABAAXBYA")
// Pass file contents to CountVowels.
// Then output the number of CABAAXBYA found in the file.

using System.Diagnostics.Metrics;

class MainClass
{
    public static void Main(string[] args)
    {
        // Pass file contents to BruteForce and print results.
        char[] sortedArray = InsertionSort(ReadFromFile());
        PrintArrayContents(sortedArray);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    /// <summary>
    /// Decrease-by-one approach. Sorts a given array by inserting sort.
    /// Pass in an array of the file contents.
    /// </summary>
    /// <param name="characterArray">An array A[0..n - 1] of n orderable elements.</param>
    /// <returns>Array A[0..n - 1] sorted in nondecreasing order.</returns>
    public static char[] InsertionSort(char[] characterArray)
    {
        for (int i = 0; i < characterArray.Length; i++)
        {
            var v = characterArray[i];
            var j = i - 1;
            //Console.WriteLine($"For characterArray[i] {characterArray[i]}");

            while (j >= 0 && characterArray[j] > v)
            {
                characterArray[j + 1] = characterArray[j];
                j = j - 1;
                characterArray[j + 1] = v;
            }

            //Console.WriteLine($"For characterArray[i] {characterArray[i]}");
        }

        return characterArray;
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
        string message = $"\nSearching for {searchStringStart} " +
            $" and {searchStringEnd} in this character array {characterArray}";
        Console.WriteLine(message);

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

    public static void PrintArrayContents(char[] characterArray)
    {
        for (int i = 0; i < characterArray.Length; i++)
        {
            Console.WriteLine(characterArray[i]); 
        }
    }

    private static char[] ReadFromFile()
    {
        string fileName = "data.txt";
        string projectFolder = "Week3-Decrease-and-Conquer";
        string solutionFolderPath = "/Users/antonio/repo/CPSC-5031-Algorithms/";
        string fullFilePath = $"{solutionFolderPath}/{projectFolder}/{fileName}"; 

        // Read from contents from file(e.g. "CABAAXBYA").
        Console.WriteLine($"Reading file {fullFilePath}\n");

        // Read text from text file and store in string.
        string text = File.ReadAllText(fullFilePath);

        // Convert userInput to lowercase.
        string lowerCase = text.ToLower();

        // File contents(e.g. "CABAAXBYA").
        Console.WriteLine($"File contents: {lowerCase}\n");

        // Covert to string to array and store in arr variable.
        char[] characterArray = lowerCase.ToCharArray();

        // Pass the file contents to the function.
        return characterArray;
    }
}