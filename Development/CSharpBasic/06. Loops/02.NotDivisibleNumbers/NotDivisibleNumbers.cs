namespace _02.NotDivisibleNumbers
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Write a program that reads from the console a positive integer N and prints all the numbers 
    /// from 1 to N not divisible by 3 or 7, on a single line, separated by a space.
    /// </summary>
    public class NotDivisibleNumbers
    {
        public static void Main()
        {
            List<ushort> numbers = new List<ushort>();
            ushort number = ushort.Parse(Console.ReadLine());
            for (ushort i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    numbers.Add(i);
                }   
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
