namespace _07.Workdays
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a method that calculates the number of workdays between today and a given date, passed as parameter. 
    /// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
    /// </summary>
    public class Workdays
    {
        public static void Main()
        {
            DateTime endDate = DateTime.Today;
            DateTime startDate = new DateTime(2017, 1, 1);

            var holidays = new List<DateTime>()
            {
                new DateTime(2017, 1, 2),
                new DateTime(2017, 3, 3),
                new DateTime(2017, 4, 14),
                new DateTime(2017, 9, 6)
            };

            int workingDays = 0;
            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek != DayOfWeek.Sunday
                    && startDate.DayOfWeek != DayOfWeek.Saturday
                    && !holidays.Contains(startDate))
                {
                    workingDays++;
                }

                startDate = startDate.AddDays(1);
            }

            Console.WriteLine(workingDays);
        }
    }
}
