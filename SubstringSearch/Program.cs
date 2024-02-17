/* Name: Antonio Santana
 * Problem: Write a function that searches a string S for the first occurrence of substring U. If the substring
 * is found, return the character index where U starts. If the substring is not found, return -1.
 * 
 * Here are the test cases you should include:
 * S                    U       result
 * Happy happy joy joy  happy   6
 * Where is the dog?    cat     -1
 * fun fun fun          fun     0
 * I love coding!       Me too! -1
 */

static int substringSearch(string inputString, string inputSubString)
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
                //Console.WriteLine(inputString.IndexOf(inputString[i]));
                return inputString.IndexOf(inputString[i]);
            }
        }
    }

    return -1;
}

string inputString = "Happy happy joy joy";
string inputSubString = "happy";
Console.WriteLine("\nCharacter Index where U starts: {0}", substringSearch(inputString, inputSubString));