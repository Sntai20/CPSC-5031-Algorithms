﻿/*
* Reference: https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
*/

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

Console.WriteLine("Fibonacci Iterative");
FibonacciIterative(10);

Console.WriteLine("\nFibonacci Recursive");
FibonacciRecursive(10);