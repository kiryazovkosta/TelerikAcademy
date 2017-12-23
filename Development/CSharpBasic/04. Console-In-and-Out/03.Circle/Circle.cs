namespace _03.Circle
{
    using System;
    using System.Globalization;
    using System.Threading;
    /// <summary>
    /// Write a program that reads from the console the radius r of a circle and prints its perimeter and area, 
    /// rounded and formatted with 2 digits after the decimal point.
    /// </summary>
    public class Circle
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
        }
    }
}
