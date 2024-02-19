/* Name: Antonio Santana
 * Problem: In figure (a), you have a knapsack (bag) that can hold a maximum weight of 10. There are four
 * items with given weights and dollar values. What is the maximum value you can put in the knapsack?
 */
namespace FileProcessorTest;

using FileProcessor;

public class FileProcessorTest
{
    [Fact]
    public void ProcessData_WhenFileIsEmpty_ReturnsZero()
    {
        // Arrange
        string filePath = "Resources//emptydata.txt";
        var expected = 0;

        // Act
        var actual = FileProcessor.ProcessData(filePath);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ProcessData_WhenFileContainsTwoEntries_ReturnTwo()
    {
        // Arrange
        string filePath = "Resources//data.txt";
        var expected = 2;

        // Act
        var actual = FileProcessor.ProcessData(filePath);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSHA256HashFromFile_WhenFileContainsTwoEntries_ReturnSHA256Hash()
    {
        // Arrange
        string filePath = "Resources//data.txt";
        var expected = "4bd2ff212e7fd881d4e8cbb56bb1c817db63bd508b2958ef34d57aee06dc46f3";

        // Act
        var actual = FileProcessor.GetSHA256HashFromFile(filePath);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSHA256HashFromFile_WhenFileEmpty_ReturnSHA256Hash()
    {
        // Arrange
        string filePath = "Resources//emptydata.txt";
        var expected = "b75a2aa61b4062dd7c4b8cd0f02b817e734f15e9524d49ed36aa4b9348b9464e";

        // Act
        var actual = FileProcessor.GetSHA256HashFromFile(filePath);

        // Assert
        Assert.Equal(expected, actual);
    }
}