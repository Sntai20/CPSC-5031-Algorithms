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
    public void SearchForSubString_WhenInputStringContainshappy_ReturnSix()
    {
        // Arrange
        string inputString = "Happy happy joy joy";
        string inputSubString = "happy";
        int expected = 6;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchForSubString_WhenInputStringContainscat_ReturnsMinusOne()
    {
        // Arrange
        string inputString = "Where is the dog?";
        string inputSubString = "cat";
        int expected = -1;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchForSubString_WhenInputStringContainsfun_ReturnZero()
    {
        // Arrange
        string inputString = "fun fun fun";
        string inputSubString = "fun";
        int expected = 0;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchForSubString_WhenInputStringContainsMetoo_ReturnsMinusOne()
    {
        // Arrange
        string inputString = "I love coding!";
        string inputSubString = "Me too!";
        int expected = -1;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SubstringSearch_WhenInputStringContainsInputSubstring_ReturnsIndexOfFirstOccurrence()
    {
        // Arrange
        string inputString = "Hello, world!";
        string inputSubString = "world";
        int expected = 7;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SubstringSearch_WhenInputStringDoesNotContainInputSubstring_ReturnsMinusOne()
    {
        // Arrange
        string inputString = "Hello, world!";
        string inputSubString = "foo";
        int expected = -1;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SubstringSearch_WhenInputStringIsEmpty_ReturnsMinusOne()
    {
        // Arrange
        string inputString = "";
        string inputSubString = "foo";
        int expected = -1;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SubstringSearch_WhenInputSubstringIsEmpty_ReturnsMinusOne()
    {
        // Arrange
        string inputString = "Hello, world!";
        string inputSubString = "";
        int expected = -1;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SubstringSearch_WhenInputSubstringIsLongerThanInputString_ReturnsMinusOne()
    {
        // Arrange
        string inputString = "Hello";
        string inputSubString = "Hello, world!";
        int expected = -1;

        // Act
        int actual = SubstringSearch.substringSearch(inputString, inputSubString);

        // Assert
        Assert.Equal(expected, actual);
    }
}       