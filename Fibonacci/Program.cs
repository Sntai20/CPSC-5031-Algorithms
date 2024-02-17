/* Name: Antonio Santana
 * Problem: Write a program in the language of your choice that implements Fibonacci in each of the first three
 * techniques and counts the number of addition operations when called.
 */

static int FibonacciRecursiveClassic(int numberOfElements)
{
    switch (numberOfElements)
    {
        case 0:
            return 0;
        case 1:
            return 1;
        default:
            return FibonacciRecursiveClassic(numberOfElements - 1) + FibonacciRecursiveClassic(numberOfElements - 2);
    }
}

// This code is similar to the FibonacciRecursiveClassic, but uses if/else instead of a switch case.
static int FibonacciRecursiveAlternative(int numberOfElements)
{
    if ((numberOfElements == 0) || (numberOfElements == 1))
    {
        return numberOfElements;
    }
    else
    {
        return FibonacciRecursiveAlternative(numberOfElements - 1) + FibonacciRecursiveAlternative(numberOfElements - 2);
    }
}

static void FibonacciRecursive(int numberOfElements)
{
    Console.WriteLine("\nFibonacci Recursive: Input {0}", numberOfElements);
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
    else
    {
        // Count the number of addition operations called.
        Console.WriteLine("\nNumber of addition operations counter {0}", counter);
    }
}

static void FibonacciIterative(int numberOfElements)
{
    int firstNumber = 0, secondNumber = 1, nextNumber, counter = 1;

    Console.WriteLine("\nFibonacci Iterative: Input {0}", numberOfElements);
    Console.Write("{0} {1}", firstNumber, secondNumber);
    for (int i = 2; i < numberOfElements; i++)
    {
        nextNumber = firstNumber + secondNumber;
        counter++;
        Console.Write(" {0}", nextNumber);
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }

    // Count the number of addition operations called.
    Console.WriteLine("\nNumber of addition operations counter {0}", counter);
}

static int FibonacciRecursiveAccumulator(
    int numberOfElements,
    int firstNumber = 0,
    int secondNumber = 1)
{
    switch (numberOfElements)
    {
        case 0:
            return firstNumber;
        default:
            return FibonacciRecursiveAccumulator(numberOfElements - 1, secondNumber, firstNumber + secondNumber);
    }
}

/* Driver code calls the methods FibonacciRecursiveClassic, FibonacciRecursive, FibonacciIterative, and
 * FibonacciRecursiveAccumulator. The driver code test the methods with the values 3, 10, and 20. If available,
 * the output of each method should provide the total number of addition operations performed.
 *
 * For the given input of 10, there are 9 addition operations performed in the recursive version. The recursive
 * Fibonacci can be less efficient due to repeated calculations, especially for larger values of number.
 *
 * Observing the number of addition operations is not as straightforward with the FibonacciRecursiveClassic
 * or FibonacciRecursiveAccumulator methods as it is with the FibonacciRecursive and FibonacciIterative methods.
 *
 * Expected output:
 *
 * Fibonacci Recursive Classic: Input 3
 *
 * Fibonacci Recursive: Input 3
 * 0 1 1
 * Number of addition operations counter 3
 *
 * Fibonacci Iterative: Input 3
 * 0 1 1
 * Number of addition operations counter 2
 *
 * Fibonacci Recursive with accumulator: Input 3
 *
 * Fibonacci Recursive Classic: Input 10
 *
 * Fibonacci Recursive: Input 10
 * 0 1 1 2 3 5 8 13 21 34
 * Number of addition operations counter 10
 *
 * Fibonacci Iterative: Input 10
 * 0 1 1 2 3 5 8 13 21 34
 * Number of addition operations counter 9
 *
 * Fibonacci Recursive with accumulator: Input 10
 *
 * Fibonacci Recursive Classic: Input 20
 *
 * Fibonacci Recursive: Input 20
 * 0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181
 * Number of addition operations counter 20
 *
 * Fibonacci Iterative: Input 20
 * 0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181
 * Number of addition operations counter 19
 *
 * Fibonacci Recursive with accumulator: Input 20
 */
int[] numbers = { 3, 10, 20 };
foreach (int number in numbers)
{
    Console.WriteLine("\nFibonacci Recursive Classic: Input {0}", number);
    FibonacciRecursiveClassic(number);

    FibonacciRecursive(number);

    FibonacciIterative(number);

    Console.WriteLine("\nFibonacci Recursive with accumulator: Input {0}", number);
    FibonacciRecursiveAccumulator(number);
}