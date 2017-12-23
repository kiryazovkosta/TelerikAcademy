using System;
using System.Threading;

namespace _03.MMSAOfNNumbers
{
    /// <summary>
    /// Write a program that reads from the console a sequence of N integer numbers and 
    /// returns the minimal, the maximal number, the sum and the average of all numbers 
    /// (displayed with 2 digits after the decimal point).
    /// </summary>
    public class MMSAOfNNumbers
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            ushort count = ushort.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }

                sum += number;
            }
            double avg = sum / count;

            Console.WriteLine(string.Format("min={0}", min));
            Console.WriteLine(string.Format("max={0}", max));
            Console.WriteLine(string.Format("sum={0}", sum));
            Console.WriteLine(string.Format("avg={0:f2}", avg));
        }
    }
}
