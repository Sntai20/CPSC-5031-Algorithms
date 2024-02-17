/* Name: Antonio Santana
 * Problem: In figure (a), you have a knapsack (bag) that can hold a maximum weight of 10. There are four
 * items with given weights and dollar values. What is the maximum value you can put in the knapsack?
 * 
 * Here are the test cases you should include:
 * S                    U       result
 * Happy happy joy joy  happy   6
 * Where is the dog?    cat     -1
 * fun fun fun          fun     0
 * I love coding!       Me too! -1
 */
namespace KnapsackProblemTest;

using KnapsackProblem;

public class KnapsackProblemMethodTest
{
    [Fact]
    public void SearchForSubStringhappyValid()
    {
        string inputString = "Happy happy joy joy";
        string inputSubString = "happy";

        int expectedValue = 6;
        int actualValue = KnapsackProblem.substringSearch(inputString, inputSubString);
        Assert.Equal(expectedValue, actualValue);
    }
}