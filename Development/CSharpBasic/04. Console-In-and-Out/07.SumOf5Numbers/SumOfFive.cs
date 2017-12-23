namespace _07.SumOf5Numbers
{
    using System;
    using System.Globalization;
    using System.Threading;
    public class SumOfFive
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double[] numbers = new double[5];
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(sum);
        }
    }
}
