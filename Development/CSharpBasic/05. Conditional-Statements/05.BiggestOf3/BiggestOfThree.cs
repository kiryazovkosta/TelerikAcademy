namespace _05.BiggestOf3
{
    using System;
    using System.Globalization;
    using System.Threading;
    /// <summary>
    /// Write a program that finds the biggest of three numbers that are read from the console.
    /// </summary>
    public class BiggestOfThree
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a > c)
            {
                Console.WriteLine(a);    
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
