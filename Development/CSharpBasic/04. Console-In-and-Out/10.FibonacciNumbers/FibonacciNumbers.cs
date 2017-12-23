namespace _10.FibonacciNumbers
{
    using System;

    /// <summary>
    /// Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence
    /// (at a single line, separated by comma and space - ", ") :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            long[] fibonacciNumbers = new long[numbersCount];
            for (int i = 0; i < numbersCount; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciNumbers[i] = i;
                }
                else
                {
                    fibonacciNumbers[i] = fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1];
                }       
            }
            if (numbersCount > 0)
            {
                Console.WriteLine(string.Join(", ", fibonacciNumbers));
            }
        }
    }
}
