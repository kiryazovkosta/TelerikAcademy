namespace _05.Calculate_
{
    using System;
    using System.Threading;
    /// <summary>
    /// Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
    /// •Use only one loop.Print the result with 5 digits after the decimal point.
    /// </summary>
    public class Calculate_
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1 + (1 / x);
            int currentNumber = 2;
            long currentProduct = 1;
            do
            {
                currentProduct *= currentNumber;
                double pow = Math.Pow(x, currentNumber);
                sum += currentProduct / pow;
            }
            while (currentNumber++ < n);

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
