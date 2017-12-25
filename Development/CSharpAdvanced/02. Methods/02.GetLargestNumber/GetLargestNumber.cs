namespace _02.GetLargestNumber
{
    using System;

    /// <summary>
    /// Write a method GetMax() with two parameters that returns the larger of two integers. 
    /// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
    /// </summary>
    public class GetLargestNumber
    {
        public static void Main(string[] args)
        {
            var numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            int largestNumber = GetMax(numbers[0], numbers[1]);
            largestNumber = GetMax(largestNumber, numbers[2]);
            Console.WriteLine(largestNumber);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }
    }
}
