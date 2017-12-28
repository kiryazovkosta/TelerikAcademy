namespace _06.TriangleSurface
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write program that calculates the surface of a triangle by given two sides and an angle between them.
    /// </summary>
    public class TriangleSurface
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var angle = Convert.ToDouble(Console.ReadLine());
            var f = (b * c * Math.Sin(ConvertToRadians(angle))) / 2;
            var s = f;
            Console.WriteLine(s.ToString("F2"));
        }

        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
