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
    public void ProcessData_WhenFileContainsOneEntry_ReturnOne()
    {
        // Arrange
        string filePath = "Resources//data.txt";
        var expected = 1;

        // Act
        var actual = FileProcessor.ProcessData(filePath);

        // Assert
        Assert.Equal(expected, actual);
    }
}