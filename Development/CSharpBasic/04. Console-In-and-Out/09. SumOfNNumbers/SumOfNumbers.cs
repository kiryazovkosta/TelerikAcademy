namespace _09.SumOfNNumbers
{
    using System;
    using System.Threading;
    /// <summary>
    /// Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
    /// </summary>
    public class SumOfNumbers
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
