/*
* Reference: https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
*/
using System;

public class Program
{
	public static void Fibonacci_Iterative(int len)
	{
		int a = 0, b = 1, c = 0;
		Console.Write("{0} {1}", a,b);
		for (int i = 2; i < len; i++)
		{
			c= a + b;
			Console.Write(" {0}", c);
			a= b;
			b= c;
		}
	}

    public static void Fibonacci_Recursive(int len)
    {
        Fibonacci_Rec_Temp(0, 1, 1, len);
    }

    private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
    {
        if (counter <= len)
        {
            Console.Write("{0} ", a);
            Fibonacci_Rec_Temp(b, a + b, counter+1, len);
        }
    }
	
	public static void Main()
	{
		Console.WriteLine("Fibonacci Iterative");
		Fibonacci_Iterative(10);

        Console.WriteLine("\nFibonacci Recursive");
        Fibonacci_Recursive(10);
	}
}