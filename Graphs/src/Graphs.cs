namespace Graphs;

public class Graphs
{
    public static int GetMaxValue(int capacity, int[] weights, int[] dollarValues)
    {
        int count = 0;
        if (weights.Length != dollarValues.Length)
        {
            Console.WriteLine("Uneven number of weights and dollar values. Please enter weight and dollar for each item.");
            return count;
        }
        else
        {
            count = weights.Length;
        }

        // Declare a two-dimensional array of integers named knapsack, which will contain the maximum dollar value of
        // the items stored within the knapsack maximum capacity.
        int[,] knapsack = new int[count + 1, capacity + 1];

        Console.WriteLine($"Total weight  Total value ");
        for (int i = 0; i <= count; ++i)
        {
            for (int w = 0; w <= capacity; ++w)
            {
                // If the knapsack is empty, set the first row and column of the knapsack array to zero.
                if (i == 0 || w == 0)
                {
                    knapsack[i, w] = 0;
                }
                // Check if the weight of the current item (weights[i - 1]) is less than or equal to the current capacity (w).
                // If yes, it means the item can be added to the knapsack.
                else if (weights[i - 1] <= w)
                {
                    // Compare the value of the bag with the new item with the current value of the bag without the
                    // item. Take the maximum of the two and stores it in knapsack[i, w].
                    var valueOfBagWithNewItem = dollarValues[i - 1] + knapsack[i - 1, w - weights[i - 1]];
                    var valueOfBag = knapsack[i - 1, w];
                    knapsack[i, w] = Math.Max(valueOfBagWithNewItem, valueOfBag);
                    Console.WriteLine($"{w}             {knapsack[i, w]}");
                }
                // Do not add the item to the knapsack, if the weight of the current item is greater than the current capacity.
                else
                {
                    // Copy the value from the previous row (knapsack[i - 1, w]) and stores it in knapsack[i, w].
                    knapsack[i, w] = knapsack[i - 1, w];
                }
            }
        }

        return knapsack[count, capacity];
    }
}