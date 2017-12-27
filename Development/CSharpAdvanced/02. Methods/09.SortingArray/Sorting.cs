namespace _09.SortingArray
{
    using System;

    /// <summary>
    /// Write a method that returns the maximal element in a portion of array of integers starting at given index. 
    /// Using it write another method that sorts an array in ascending / descending order. 
    /// Write a program that sorts a given array.
    /// </summary>
    public class Sorting
    {
        public static void Main()
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static int[] Sort(int[] numbers)
        {
            var sortedNumbers = new int[numbers.Length];
            for (int i = 0, j = numbers.Length - 1; i < numbers.Length; i++, j--)
            {
                Console.WriteLine(GetMax(numbers, i));
            }

            return sortedNumbers;
        }

        public static int GetMax(int[] numbers, int startIndex)
        {
            if (startIndex >= numbers.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            int maxNumber = int.MinValue;
            for (int i = startIndex; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }
    }
}
