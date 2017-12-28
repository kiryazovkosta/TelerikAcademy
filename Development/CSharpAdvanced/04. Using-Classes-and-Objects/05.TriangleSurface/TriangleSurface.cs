namespace _05.TriangleSurface
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write program that calculates the surface of a triangle by given its three sides.
    /// </summary>
    public class TriangleSurface
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var p = (a + b + c) / 2.0;
            var surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(surface.ToString("F2"));
        }
    }
}
