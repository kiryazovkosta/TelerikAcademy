namespace _01.SquareRoot
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write a program that reads a number and calculates and prints its square root.
    /// * If the number is invalid or negative, print Invalid number.
    /// * In all cases finally print Good bye.Use try-catch-finally block.
    /// </summary>
    public class SquareRoot
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            try
            {
                var number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    var squareRoot = Math.Sqrt(number);
                    Console.WriteLine(squareRoot.ToString("F3"));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good buy");
            }

        }
    }
}
