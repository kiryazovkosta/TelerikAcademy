namespace _08.SumIntegers
{
    using System;

    /// <summary>
    /// You are given a sequence of positive integer values written into a string, separated by spaces. 
    /// Write a function that reads these values from given string and calculates their sum. 
    /// Write a program that reads a string of positive integers separated by spaces and prints their sum.
    /// </summary>
    public class SumIntegers
    {
        public static void Main()
        {
            var numbers = ReadFromString(Console.ReadLine());
            var sum = CalculateSum(numbers);
            Console.WriteLine(sum);
        }

        public static int[] ReadFromString(string numbersAsString)
        {
            var numbers = Array.ConvertAll(numbersAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            return numbers;
        }

        public static long CalculateSum(int[] numbers)
        {
            long sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
