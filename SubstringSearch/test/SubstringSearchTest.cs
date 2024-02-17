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
namespace SubstringSearchTest;

using SubstringSearch;

public class SubstringSearchMethodTest
{
    [Fact]
    public void SearchForSubStringhappyValid()
    {
        string inputString = "Happy happy joy joy";
        string inputSubString = "happy";

        int expectedValue = 6;
        int actualValue = SubstringSearch.substringSearch(inputString, inputSubString);
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void SearchForSubStringcatValid()
    {
        string inputString = "Where is the dog?";
        string inputSubString = "cat";

        int expectedValue = -1;
        int actualValue = SubstringSearch.substringSearch(inputString, inputSubString);
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void SearchForSubStringfunValid()
    {
        string inputString = "fun fun fun";
        string inputSubString = "fun";

        int expectedValue = 0;
        int actualValue = SubstringSearch.substringSearch(inputString, inputSubString);
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void SearchForSubStringMetooValid()
    {
        string inputString = "I love coding!";
        string inputSubString = "Me too!";

        int expectedValue = -1;
        int actualValue = SubstringSearch.substringSearch(inputString, inputSubString);
        Assert.Equal(expectedValue, actualValue);
    }      
}