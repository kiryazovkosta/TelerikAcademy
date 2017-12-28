namespace _14.IntegerCalculations
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
    /// Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.
    /// </summary>
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            Console.WriteLine(Min(numbers));
            Console.WriteLine(Max(numbers));
            Console.WriteLine(Avg(numbers).ToString("F2"));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Prod(numbers));
        }

        private static long Prod(int[] numbers)
        {
            long prod = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                prod *= numbers[i];
            }

            return prod;
        }

        private static int Sum(int[] numbers)
        {
            int sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static decimal Avg(int[] numbers)
        {
            return Sum(numbers) / (decimal)numbers.Length;
        }

        private static int Max(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static int Min(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }
    }
}
