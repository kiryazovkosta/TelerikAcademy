namespace _05.LargerThanNeighbours
{
    using System;

    /// <summary>
    /// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist). 
    /// Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
    /// </summary>
    public class LargerThanNeighbours
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());

            var numbers = new int[arraySize];
            string[] numbersAsStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbers.GetLength(dimension: 0); i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }

            int largerThanNeigboursCounter = CountLargerThanNeighboursNumbers(numbers);
            Console.WriteLine(largerThanNeigboursCounter);
        }

        private static int CountLargerThanNeighboursNumbers(int[] numbers)
        {
            int counter = 0;
            for (int i = 1; i < numbers.GetLength(dimension: 0) - 1; i++)
            {
                if (numbers[i] > numbers[i - 1]
                    && numbers[i] > numbers[i + 1]
                )
                {
                    counter++;
                    i++;
                }
            }

            return counter;
        }
    }
}
