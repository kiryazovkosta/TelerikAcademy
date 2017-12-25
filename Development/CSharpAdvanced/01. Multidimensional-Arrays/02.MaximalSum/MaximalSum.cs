namespace _02.MaximalSum
{
    using System;

    /// <summary>
    /// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
    /// that has maximal sum of its elements. Print that sum.
    /// </summary>
    public class MaximalSum
    {
        public static void Main()
        {
            string[] separators = new string[] { " " };
            int[] size = Array.ConvertAll(Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int rowNumber = size[0];
            int colNumber = size[1];

            int[,] numbers = new int[rowNumber, colNumber];
            for (int rowIndex = 0; rowIndex < rowNumber; rowIndex++)
            {
                int[] rowNumbers = Array.ConvertAll(Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                for (int colIndex = 0; colIndex < colNumber; colIndex++)
                {
                    numbers[rowIndex, colIndex] = rowNumbers[colIndex];
                }
            }

            long maxSum = long.MinValue;
            long currentSum = 0;

            for (int i = 0; i < rowNumber - 2; i++)
            {
                for (int j = 0; j < colNumber - 2; j++)
                {
                    currentSum = numbers[i, j] + numbers[i, j + 1] + numbers[i, j + 2] +
                        numbers[i + 1, j] + numbers[i + 1, j + 1] + numbers[i + 1, j + 2] +
                        numbers[i + 2, j] + numbers[i + 2, j + 1] + numbers[i + 2, j + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
