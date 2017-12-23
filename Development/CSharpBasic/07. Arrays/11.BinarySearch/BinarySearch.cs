namespace _11.BinarySearch
{
    using System;

    /// <summary>
    /// Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
    /// </summary>
    public class BinarySearch
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = new int[arraySize];
            for (int index = 0; index < numbers.GetLength(dimension: 0); index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }

            int number = int.Parse(Console.ReadLine());

            int left = 0;
            int right = numbers.GetLength(dimension: 0) - 1;

            int foundedIndex = -1;
            if (number >= numbers[left] && number <= numbers[right])
            {
                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (number == numbers[middle])
                    {
                        foundedIndex = middle;
                        break;
                    }
                    else if (number < numbers[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
            }

            Console.WriteLine(foundedIndex);
        }
    }
}
