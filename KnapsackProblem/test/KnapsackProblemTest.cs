/* Name: Antonio Santana
 * Problem: In figure (a), you have a knapsack (bag) that can hold a maximum weight of 10. There are four
 * items with given weights and dollar values. What is the maximum value you can put in the knapsack?
 * 
 * Knapsack (bag) can hold a maximum weight of 10. Here is the test case to include:
 * Items  1  2  3  4
 * Weight 7  3  4  5
 * Dollar 42 12 40 25
 */
namespace KnapsackProblemTest;

using KnapsackProblem;

public class KnapsackProblemTest
{
    [Fact]
    public void GetMaxValue_WhenFourItems_ReturnSixtyFiveDollars()
    {
        // Arrange
        int maximumWeightCapacity = 10;
        int[] weights = { 7, 3, 4, 5 };
        int[] dollarValues = { 42, 12, 40, 25 };
        int expected = 65;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMaxValue_WhenOneItem_ReturnFortyTwoDollars()
    {
        // Arrange
        int maximumWeightCapacity = 10;
        int[] weights = { 7 };
        int[] dollarValues = { 42 };
        int expected = 42;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMaxValue_WhenWeightsOrDollarValuesAreEmpty_ReturnsZero()
    {
        // Arrange
        int maximumWeightCapacity = 10;
        int[] weights = Array.Empty<int>();
        int[] dollarValues = Array.Empty<int>();
        int expected = 0;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMaxValue_WhenWeightsAndDollarValuesAreNotEqualLength_ReturnsZero()
    {
        // Arrange
        int maximumWeightCapacity = 10;
        int[] weights = { 7, 3 };
        int[] dollarValues = { 42 };
        int expected = 0;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMaxValue_WhenWeightsAndDollarValuesAreEqualLength_ReturnsMaxValue()
    {
        // Arrange
        int maximumWeightCapacity = 10;
        int[] weights = { 2, 4, 6, 8 };
        int[] dollarValues = { 3, 5, 7, 9 };
        int expected = 12;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMaxValue_WhenCapacityIsZero_ReturnsZero()
    {
        // Arrange
        int maximumWeightCapacity = 0;
        int[] weights = { 2, 4, 6, 8 };
        int[] dollarValues = { 3, 5, 7, 9 };
        int expected = 0;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMaxValue_WhenCapacityIsLessThanAnyWeight_ReturnsZero()
    {
        // Arrange
        int maximumWeightCapacity = 1;
        int[] weights = { 2, 4, 6, 8 };
        int[] dollarValues = { 3, 5, 7, 9 };
        int expected = 0;

        // Act
        int actual = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);

        // Assert
        Assert.Equal(expected, actual);
    }
}