namespace _05.MaximalIncreasingSequence
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that finds the length of the maximal increasing sequence in an array of N integers.
    /// </summary>
    public class MaximalIncreasingSequence
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = new int[arraySize];
            for (int index = 0; index < arraySize; index++)
            {
                int.TryParse(Console.ReadLine(), out numbers[index]);
            }

            int maxLength = 1;
            int currentLength = 1;

            for (int index = 1; index < numbers.GetLength(dimension: 0); index++)
            {
                if (numbers[index] > numbers[index-1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }

                    currentLength = 1;
                }

                if (index == numbers.GetLength(0) - 1 && currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}
