namespace _15.GCD
{
    using System;

    /// <summary>
    /// Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
    /// </summary>
    public class GCD
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' });
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            int max = a > b ? a : b;
            int min = a <= b ? a : b;

            int div = max % min;

            while (div != 0)
            {
                max = min;
                min = div;
                div = max % min;
            }

            Console.WriteLine(min);
        }
    }
}
