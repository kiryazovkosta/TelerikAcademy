namespace _06.BiggestOf5
{
    using System;
    using System.Globalization;
    using System.Threading;
    /// <summary>
    /// Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.
    /// </summary>
    public class BiggestOf5
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double max = double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine(max);
        }
    }
}