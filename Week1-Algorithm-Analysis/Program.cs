// Read from contents from file(e.g. "Welcome to SeattleU!")
// Pass file contents to CountVowels.
// Then output the number of vowels found in the file.
using System;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        // Read from contents from file(e.g. "Welcome to SMU!")
        Console.Write("Reading file ");

        // Pass file contents to CountVowels and print results.
        Console.WriteLine(CountVowels(ReadFromFile()));

        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }

    private static string ReadFromFile()
    {
        // Read text from text file and store in string.
        string text = File.ReadAllText
            (@"/Users/antonio/repo/CPSC-5031-Algorithms/Week1-Algorithm-Analysis/data.txt");

        // Pass the file contents to the CountVowels function.
        return text;
    }

    public static int CountVowels(string userInput)
    {
        // Convert userInput to lowercase.
        string lowerCase = userInput.ToLower();

        // Covert to string to array and store in arr variable.
        char[] arr = lowerCase.ToCharArray();

        // Find the vowels in userInput
        string vowelString = "aeiouy";
        char[] vowels = vowelString.ToCharArray();

        int counter = 0;
        Console.WriteLine("\nSearching for vowels in this string");

        // Compare each character against the vowels array.
        for (int i = 0; i < arr.Length; i++)
        {
            //Console.WriteLine("Array = {0}", arr[i]);
            for (int j = 0; j < vowels.Length; j++)
            {
                // Evaluate if the userInput contains vowels.
                if (arr[i] == vowels[j])
                {
                    // Store the total number of vowels.
                    counter = counter + 1;
                }
            }
        }

        return counter;
    }
}