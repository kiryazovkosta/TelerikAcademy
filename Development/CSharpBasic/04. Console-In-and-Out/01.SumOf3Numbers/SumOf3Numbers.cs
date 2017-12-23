namespace _01.SumOf3Numbers
{
    using System;
    using System.Threading;
    /// <summary>
    /// Write a program that reads 3 real numbers from the console and prints their sum.
    /// </summary>
    public class SumOf3Numbers
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
