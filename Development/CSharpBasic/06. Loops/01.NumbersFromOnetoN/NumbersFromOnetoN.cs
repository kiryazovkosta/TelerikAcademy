namespace _01.NumbersFromOnetoN
{
    using System;

    /// <summary>
    /// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, 
    /// on a single line, separated by a whitespace.
    /// </summary>
    public class NumbersFromOnetoN
    {
        public static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint[] numbers = new uint[number];
            for (uint i = 1; i <= number; i++)
            {
                numbers[i - 1] = i;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
