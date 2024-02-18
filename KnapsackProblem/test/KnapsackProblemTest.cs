/* Name: Antonio Santana
 * Problem: In figure (a), you have a knapsack (bag) that can hold a maximum weight of 10. There are four
 * items with given weights and dollar values. What is the maximum value you can put in the knapsack?
 * 
 * Here are the test cases you should include:
 * Items  Weight  Dollar
 * 1      7       42
 * 2      3       12
 * 3      4       40
 * 4      5       25
 * 
 * Knapsack (bag) can hold a maximum weight of 10.
 */
namespace KnapsackProblemTest;

using KnapsackProblem;

public class KnapsackProblemTest
{
    [Fact]
    public void GetMaxValue_FourItems_ReturnSixtyFiveDollars_Valid()
    {
        int maximumWeightCapacity = 10;
        int[] weights = { 7, 3, 4, 5 };
        int[] dollarValues = { 42, 12, 40, 25 };

        int expectedValue = 65;
        int actualValue = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void GetMaxValue_OneItem_ReturnFortyTwoDollars_Valid()
    {
        int maximumWeightCapacity = 10;
        int[] weights = { 7 };
        int[] dollarValues = { 42 };

        int expectedValue = 42;
        int actualValue = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void GetMaxValue_EmptyValues_ReturnZero_Valid()
    {
        int maximumWeightCapacity = 10;
        int[] weights = Array.Empty<int>();
        int[] dollarValues = Array.Empty<int>();

        int expectedValue = 0;
        int actualValue = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void GetMaxValue_UnevenValues_ReturnZero_NotValid()
    {
        int maximumWeightCapacity = 10;
        int[] weights = { 7, 3 };
        int[] dollarValues = { 42 };

        int expectedValue = 0;
        int actualValue = KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);
        Assert.Equal(expectedValue, actualValue);
    }
}