namespace _03.SequenceInMatrix
{
    using System;

    /// <summary>
    /// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. 
    /// Write a program that finds the longest sequence of equal strings in the matrix and prints its length.
    /// </summary>
    public class SequenceInMatrix
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

            long maxSequence = 0;
            long currentSequence = 0;

            // horizontal check
            for (int rowIndex = 0; rowIndex < rowNumber; rowIndex++)
            {
                currentSequence = 1;

                for (int colIndex = 0; colIndex < colNumber - 1; colIndex++)
                {
                    if (numbers[rowIndex, colIndex] == numbers[rowIndex, colIndex + 1])
                    {
                        currentSequence++;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                    if (numbers[rowIndex, colIndex] != numbers[rowIndex, colIndex + 1])
                    {
                        currentSequence = 1;
                    }
                }
            }

            // vertical check 
            for (int colIndex = 0; colIndex < colNumber; colIndex++)
            {
                currentSequence = 1;

                for (int rowIndex = 0; rowIndex < rowNumber - 1; rowIndex++)
                {
                    if(numbers[rowIndex, colIndex] == numbers[rowIndex + 1, colIndex])
                    {
                        currentSequence++;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                    if (numbers[rowIndex, colIndex] != numbers[rowIndex + 1, colIndex])
                    {
                        currentSequence = 1;
                    }
                }
            }

            // diagonal check - first half
            //for (int rowIndex = rowNumber - 1; rowIndex >= 0; rowIndex--)
            //{
            //    currentSequence = 1;

            //    for (int colIndex = 0; rowIndex < rowNumber - 1; rowIndex++)
            //    {
            //        //if (numbers[rowIndex, colIndex] == numbers[rowIndex + 1, colIndex])
            //        //{
            //        //    currentSequence++;
            //        //}

            //        //if (currentSequence > maxSequence)
            //        //{
            //        //    maxSequence = currentSequence;
            //        //}

            //        //if (numbers[rowIndex, colIndex] != numbers[rowIndex + 1, colIndex])
            //        //{
            //        //    currentSequence = 1;
            //        //}
            //    }
            //}

            Console.WriteLine(maxSequence);
        }
    }
}
