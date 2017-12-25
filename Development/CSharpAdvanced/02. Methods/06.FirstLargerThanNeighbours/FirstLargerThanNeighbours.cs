namespace _06.FirstLargerThanNeighbours
{
    using System;

    /// <summary>
    /// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.
    /// </summary>
    public class FirstLargerThanNeighbours
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

            int index = FindFirstLargerThanNeighbours(numbers);
            Console.WriteLine(index);
        }

        private static int FindFirstLargerThanNeighbours(int[] numbers)
        {
            int index = -1;
            for (int i = 1; i < numbers.GetLength(dimension: 0) - 1; i++)
            {
                if (numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
