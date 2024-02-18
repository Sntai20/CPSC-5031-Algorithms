namespace SubstringSearch;

public class SubstringSearch
{
    public static int substringSearch(string inputString, string inputSubString)
    {
        Console.WriteLine("String to search through: {0}", inputString);
        Console.WriteLine("Substring to search for: {0}", inputSubString);

        int characterMatchCount = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            // Search for the first occurrence of the substring.
            if (inputString[i] == inputSubString[0])
            {
                // If the substring is found, return the character index where U starts.
                Console.Write(inputString[i]);
                characterMatchCount++;
                for (int j = 1; j < inputSubString.Length; j++)
                {
                    if (inputString[i + j] == inputSubString[j])
                    {
                        Console.Write(inputString[i + j]);
                        characterMatchCount++;
                    }
                }

                // Return the character index where U starts.
                if (inputSubString.Length == characterMatchCount)
                {
                    Console.WriteLine("\nCharacter Index where U starts: {0}", inputString.IndexOf(inputString[i]));
                    return inputString.IndexOf(inputString[i]);
                }
            }
        }

        return -1;
    }
}