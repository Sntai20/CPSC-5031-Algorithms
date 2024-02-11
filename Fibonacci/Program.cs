/*
 * Problem: Write a program in the language of your choice that implements Fibonacci in each of the first three
 * techniques and counts the number of addition operations when called.
 * Reference: https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
 */

static int FibonacciRecursiveClassic(int numberOfElements)
{
    Console.Write("{0}", numberOfElements);
    switch (numberOfElements)
    {
        case 0:
            //Console.Write("{0}", 0);
            return 0;
        case 1:
            //Console.Write("{0}", 1);
            return 1;
        default:
            //Console.Write("{0} ", ((numberOfElements - 1) + (numberOfElements - 2)));
            return FibonacciRecursiveClassic(numberOfElements - 1) + FibonacciRecursiveClassic(numberOfElements - 2);
    }
}

static void FibonacciRecursive(int numberOfElements)
{
    FibonacciRecursiveTemp(0, 1, 1, numberOfElements);
}

static void FibonacciRecursiveTemp(
    int firstNumber,
    int secondNumber,
    int counter,
    int numberOfElements)
{
    Console.Write(firstNumber + " ");
    if (counter < numberOfElements)
    {
        FibonacciRecursiveTemp(
            secondNumber,
            firstNumber + secondNumber,
            counter + 1,
            numberOfElements);
    }
}

static void FibonacciIterative(int numberOfElements)
{
    int firstNumber = 0, secondNumber = 1, nextNumber;

    if (numberOfElements < 2)
    {
        Console.Write("Please Enter a number greater than two");
    }
    else
    {
        Console.Write("{0} {1}", firstNumber, secondNumber);
        for (int i = 2; i < numberOfElements; i++)
        {
            nextNumber = firstNumber + secondNumber;
            Console.Write(" {0}", nextNumber);
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}

static void FibonacciRecursiveAccumulator(int numberOfElements)
{
    FibonacciRecursiveAccumulatorTemp(0, 1, 1, numberOfElements);
}

static void FibonacciRecursiveAccumulatorTemp(
    int firstNumber,
    int secondNumber,
    int counter,
    int numberOfElements)
{
    if (counter <= numberOfElements)
    {
        Console.Write("{0} ", firstNumber);
        FibonacciRecursiveAccumulatorTemp(
            secondNumber,
            firstNumber + secondNumber,
            counter + 1,
            numberOfElements);
    }
}

//Console.WriteLine("Fibonacci Recursive Classic");
//FibonacciRecursiveClassic(10);

Console.WriteLine("\nFibonacci Recursive");
FibonacciRecursive(10);

Console.WriteLine("\nFibonacci Iterative");
FibonacciIterative(10);

Console.WriteLine("\nFibonacci Recursive with accumulators");
FibonacciRecursiveAccumulator(10);