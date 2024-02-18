int maximumWeightCapacity = 10;
int[] weights = { 7, 3, 4, 5 };
int[] dollarValues = { 42, 12, 40, 25 };

int expectedValue = 65;
int actualValue = KnapsackProblem.KnapsackProblem.GetMaxValue(maximumWeightCapacity, weights, dollarValues);
if (expectedValue == actualValue)
{
    Console.WriteLine("Working");
}