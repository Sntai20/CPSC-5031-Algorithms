class MainClass
{
    public static void Main(string[] args)
    {
        int[] unsortedArray = new int[] { 8, 3, 2, 5, 1, 4, 6, 9, 7 };
        int[] sortedIntegerArray = InsertionSort(unsortedArray);
        PrintArrayContents(sortedIntegerArray);

        // Pass file contents to BruteForce and print results.
        char[] sortedCharacterArray = InsertionSort(ReadFromFile());
        PrintArrayContents(sortedCharacterArray);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    /// <summary>
    /// Decrease-by-one approach. Sorts a given array by inserting sort.
    /// </summary>
    /// <param name="intArray">An array A[0..n - 1] of n orderable elements.</param>
    /// <returns>Array A[0..n - 1] sorted in nondecreasing order.</returns>
    public static int[] InsertionSort(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            // v is the current element value.
            var v = intArray[i];

            // j is the last element in the array.
            var j = i - 1;

            // As long as j is not at the begining of the array and if the value in
            // the j element is larger than the value of current element's value,
            // compare each character with j 
            while (j >= 0 && intArray[j] > v)
            {
                intArray[j + 1] = intArray[j];
                j = j - 1;
            }

            intArray[j + 1] = v;
        }

        return intArray;
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
            // j is the last character in the array.
            var j = i - 1;
            //Console.WriteLine($"For characterArray[i] {characterArray[i]}");

            // As long as j is not at the begining of the array and if j is larger
            // than the current element,  compare each character with j 
            while (j >= 0 && characterArray[j] > v)
            {
                characterArray[j + 1] = characterArray[j];
                j = j - 1;
            }
            characterArray[j + 1] = v;

            //Console.WriteLine($"For characterArray[i] {characterArray[i]}");
        }

        return characterArray;
    }

    private static void PrintArrayContents(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
    }

    private static void PrintArrayContents(char[] characterArray)
    {
        for (int i = 0; i < characterArray.Length; i++)
        {
            Console.WriteLine(characterArray[i]); 
        }
    }

    private static char[] ReadFromFile()
    {
        // Read from contents from file(e.g. "CABAAXBYA")
        // Pass file contents to CountVowels.
        // Then output the number of CABAAXBYA found in the file.

        string fileName = "data.txt";
        string projectFolder = "Week3-Decrease-and-Conquer";
        string solutionFolderPath = "/Users/antonio/repo/CPSC-5031-Algorithms/";
        string fullFilePath = $"{solutionFolderPath}/{projectFolder}/{fileName}"; 

        // Read from contents from file(e.g. "CABAAXBYA").
        Console.WriteLine($"\nReading file {fullFilePath}\n");

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