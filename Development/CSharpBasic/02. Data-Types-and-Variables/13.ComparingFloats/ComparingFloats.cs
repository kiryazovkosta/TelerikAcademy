namespace _13.ComparingFloats
{
    using System;
    using System.Threading;

    /// <summary>
    /// Write a program that safely compares two floating-point numbers (double) with precision  eps = 0.000001 .
    /// </summary>
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double esp = 0.000001;
            var difference = Math.Abs(a - b);
            var areEquals = esp > difference;
            Console.WriteLine(areEquals.ToString().ToLower());
        }
    }
}