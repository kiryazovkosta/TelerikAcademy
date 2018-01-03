namespace _05.MaximalAreaSum
{
    using System;
    using System.IO;

    /// <summary>
    /// Write a program that reads a text file containing a square matrix of numbers. 
    /// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
    /// * The first line in the input file contains the size of matrix N.
    /// * Each of the next N lines contain N numbers separated by space.
    /// * The output should be a single number in a separate text file.
    /// </summary>
    public class MaximalAreaSum
    {
        public static void Main()
        {
            var fileName = @"C:\Temp\matrix.txt";
            var outFile = @"C:\Temp\output.txt";
            using (var reader = new StreamReader(fileName))
            {
                int size = Convert.ToInt32(reader.ReadLine().Trim());
                int[,] numbers = new int[size, size];
                int rowIndex = 0;

                string line = reader.ReadLine();
                while (line != null)
                {
                    int[] rowNumbers = Array.ConvertAll(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
                    for (int i = 0; i < numbers.GetLength(1); i++)
                    {
                        numbers[rowIndex, i] = rowNumbers[i];
                    }

                    rowIndex++;
                    line = reader.ReadLine();
                }

                long maxSum = long.MinValue;
                long currentSum = 0;

                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - 1; j++)
                    {
                        currentSum = numbers[i, j] + numbers[i, j + 1] + numbers[i + 1, j] + numbers[i + 1, j + 1];

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                        }
                    }
                }

                if (File.Exists(outFile))
                {
                    File.Delete(outFile);
                }

                using (var writer = new StreamWriter(outFile))
                {
                    writer.Write(maxSum);
                }
            }
        }
    }
}
