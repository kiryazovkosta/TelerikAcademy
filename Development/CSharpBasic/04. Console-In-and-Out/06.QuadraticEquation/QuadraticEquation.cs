namespace _06.QuadraticEquation
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
    /// and solves it (prints its real roots).
    /// </summary>
    public class QuadraticEquation
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                if (x1 > x2)
                {
                    double temp = x1;
                    x1 = x2;
                    x2 = temp;
                }
                Console.WriteLine("{0:f2}\n{1:f2}", x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("{0:f2}", x);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
