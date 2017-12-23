namespace _16.Trailing0inN_
{
    using System;
    using System.Numerics;
    /// <summary>
    /// Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
    /// •Your program should work well for very big numbers, e.g.N = 100000.
    /// 
    /// http://www.geeksforgeeks.org/count-trailing-zeroes-factorial-number/
    /// </summary>
    public class Trailing0inN_
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int zeroCounter = 0;
            for (int i = 5; number / i >= 1; i *= 5)
            {
                zeroCounter += number / i;
            }

            Console.WriteLine(zeroCounter);
        }
    }
}