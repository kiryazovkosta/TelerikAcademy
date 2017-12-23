namespace _02.MoonGravity
{
    using System;
    using System.Threading;
    /// <summary>
    /// The gravitational field of the Moon is approximately 17% of that on the Earth.
    /// • Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
    /// • The weight W should be read from the console.
    /// </summary>
    public class MoonGravity
    {
        public static void Main()
        {
            double approximately = 17;
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = (weightOnEarth / 100) * approximately;
            Console.WriteLine("{0:N3}", weightOnMoon);
        }
    }
}
