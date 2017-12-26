namespace _01.FillTheMatrix
{
    using System;

    public class FillTheMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char inputChar = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int[] numbers = new int[n * n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                //Console.WriteLine(numbers[i]);
            }

            //Array.Sort(numbers);

            //check which case matched 
            if (inputChar == 'a')
            {
                FillMatrixCaseA(matrix, numbers);
                PrintTheMatrix(matrix);
            }
            else if (inputChar == 'b')
            {
                FillMatrixCaseB(matrix, numbers);
                PrintTheMatrix(matrix);
            }
            else if (inputChar == 'c')
            {
                FillMatrixCaseC(matrix, numbers);
                PrintTheMatrix(matrix);
            }
            else if (inputChar == 'd')
            {
                FillMatrixCaseD(matrix);
                PrintTheMatrix(matrix);
            }
        }

        private static void FillMatrixCaseA(int[,] matrix, int[] numbers)
        {
            int index = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = numbers[index];
                    index++;
                }
            }
        }

        private static void FillMatrixCaseB(int[,] matrix, int[] numbers)
        {
            int index = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // if row is even fill the matrix in normal order
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[col, row] = numbers[index];
                        index++;
                    }
                }
                // if row is odd fill the matrix in reverse order
                else if (row % 2 == 1)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[col, row] = numbers[index];
                        index++;
                    }
                }

            }
        }

        private static void FillMatrixCaseC(int[,] matrix, int[] numbers)
        {
            int index = 0;
            int row = 0;
            int col = 0;

            FillElementsInMatrixTillMainDiagonal(matrix, row, col, ref index, numbers);
            FillElementsInMatrixAfterMainDiagonal(matrix, row, col, ref index, numbers);
        }

        private static void FillElementsInMatrixTillMainDiagonal(int[,] matrix, int row, int col, ref int index, int[] numbers)
        {
            // fill numbers in the matrix till the main diagonal incl.
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        row = i;
                        col = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;

                    if (row == matrix.GetLength(0) - 1)
                    {
                        break;
                    }

                    row++;
                    col++;
                }
            }
        }

        private static void FillElementsInMatrixAfterMainDiagonal(int[,] matrix, int row, int col, ref int index, int[] numbers)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        col = i;
                        row = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;

                    if (col == matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    row++;
                    col++;
                }
            }
        }

        private static void FillMatrixCaseD(int[,] matrix)
        {
            int col = 0;
            int row = 0;
            int direction = 0;
            int side = matrix.GetLength(0);

            int[,] nav =
            {
                { 1, 0 },
                { 0, 1 },
                { -1, 0 },
                { 0, -1 }
            };

            for (int i = 1; i <= side * side; i++)
            {
                matrix[col, row] = i;

                var nextX = col + nav[direction, 0];
                var nextY = row + nav[direction, 1];

                if (nextX == side || nextX == -1 || nextY == side || nextY == -1 || matrix[nextX, nextY] != 0)
                {
                    direction++;
                    direction %= 4;
                }

                col += nav[direction, 0];
                row += nav[direction, 1];
            }
        }

        private static void PrintTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                        continue;
                    }

                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
