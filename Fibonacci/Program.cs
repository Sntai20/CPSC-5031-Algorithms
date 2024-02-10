/*
 * Problem: Write a program in the language of your choice that implements Fibonacci in each of the first three
 * techniques and counts the number of addition operations when called.
 * Reference: https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
 */

static void FibonacciRecursive(int length)
{
    FibonacciRecursiveTemp(0, 1, 1, length);
}

static void FibonacciRecursiveTemp(int a, int b, int counter, int length)
{
    if (counter <= length)
    {
        Console.Write("{0} ", a);
        FibonacciRecursiveTemp(b, a + b, counter + 1, length);
    }
}

static void FibonacciIterative(int length)
{
    int a = 0, b = 1, c = 0;
    Console.Write("{0} {1}", a, b);
    for (int i = 2; i < length; i++)
    {
        c = a + b;
        Console.Write(" {0}", c);
        a = b;
        b = c;
    }
}

static void FibonacciRecursiveAccumulator(int length)
{
    FibonacciRecursiveTemp(0, 1, 1, length);
}

static void FibonacciRecursiveAccumulatorTemp(int a, int b, int counter, int length)
{
    if (counter <= length)
    {
        Console.Write("{0} ", a);
        FibonacciRecursiveAccumulatorTemp(b, a + b, counter + 1, length);
    }
}

Console.WriteLine("Fibonacci Recursive");
FibonacciRecursive(10);

Console.WriteLine("\nFibonacci Iterative");
FibonacciIterative(10);

Console.WriteLine("\nFibonacci Recursive with accumulators");
FibonacciRecursiveAccumulator(10);