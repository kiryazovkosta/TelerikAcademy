namespace _11.Interval
{
    using System;

    /// <summary>
    /// Write a program that reads two positive integer numbers N and M and prints how many numbers exist 
    /// between them such that the reminder of the division by 5 is 0.
    /// </summary>
    public class DividedBy5InInterval
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int dividedByFiveCount = 0;
            for (int i = n + 1; i < m; i++)
            {
                if (i%5 == 0)
                {
                    dividedByFiveCount++;
                }
            }

            Console.WriteLine(dividedByFiveCount);
        }
    }
}
