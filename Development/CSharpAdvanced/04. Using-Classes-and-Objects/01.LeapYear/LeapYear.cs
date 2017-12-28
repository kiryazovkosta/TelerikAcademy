namespace _01.LeapYear
{
    using System;

    /// <summary>
    /// Write a program that reads a year from the console and checks whether it is a leap one.
    /// </summary>
    public class LeapYear
    {
        public static void Main()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
