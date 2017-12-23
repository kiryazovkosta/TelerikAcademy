namespace _05.NumbersComparer
{
    using System;
    using System.Threading;

    /// <summary>
    /// Write a program that gets two numbers from the console and prints the greater of them.
    /// </summary>
    public class GreaterNumber
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double a;
            bool isValid = double.TryParse(Console.ReadLine(), out a);

            double b;
            isValid = double.TryParse(Console.ReadLine(), out b);
            if (isValid)
            {
                double max = a > b ? a : b;
                Console.WriteLine(max);
            }
        }
    }
}
