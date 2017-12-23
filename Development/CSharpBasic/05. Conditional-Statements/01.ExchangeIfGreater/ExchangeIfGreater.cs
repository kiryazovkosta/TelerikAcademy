namespace _01.ExchangeIfGreater
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write a program that reads two double values from the console A and B, stores them in variables and 
    /// exchanges their values if the first one is greater than the second one. 
    /// Use an if-statement. As a result print the values of the variables A and B, separated by a space.
    /// </summary>
    public class ExchangeIfGreater
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            string outputMessage = string.Format("{0} {1}", a, b);
            Console.WriteLine(outputMessage);
        }
    }
}
