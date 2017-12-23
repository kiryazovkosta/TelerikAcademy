namespace _04.MultiplicationSign
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write a program that shows the sign (+, - or 0) of the product of three real numbers.
    /// </summary>
    public class MultiplicationSign
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double result = a * b * c;
            if (result > 0)
            {
                Console.WriteLine("+");
            }
            else if (result < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}