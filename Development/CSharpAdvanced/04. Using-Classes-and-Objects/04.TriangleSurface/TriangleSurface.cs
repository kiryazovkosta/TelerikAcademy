namespace _04.TriangleSurface
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write program that calculates the surface of a triangle by given a side and an altitude to it.
    /// </summary>
    public class TriangleSurface
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var side = Convert.ToDouble(Console.ReadLine());
            var altitude = Convert.ToDouble(Console.ReadLine());
            var surface = (side * altitude) / 2.0;
            Console.WriteLine(surface.ToString("F2"));
        }
    }
}
