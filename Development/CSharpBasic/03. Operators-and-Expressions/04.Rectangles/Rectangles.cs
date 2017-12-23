namespace _04.Rectangles
{
    using System;
    using System.Threading;
    /// <summary>
    /// Write an expression that calculates rectangle’s perimeter and area by given width and height. 
    /// The width and height should be read from the console.
    /// </summary>
    public class Rectangles
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = width * height;
            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}