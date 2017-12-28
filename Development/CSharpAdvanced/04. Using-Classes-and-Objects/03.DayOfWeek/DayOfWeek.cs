namespace _03.DayOfWeek
{
    using System;

    /// <summary>
    /// Write a program that prints to the console which day of the week is today. Use System.DateTime.
    /// </summary>
    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }
    }
}
