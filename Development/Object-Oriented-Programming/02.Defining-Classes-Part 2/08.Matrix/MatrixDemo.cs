namespace _08.Matrix
{
    using System;
    using System.Linq;
    using System.Text;

    public class MatrixDemo
    {
        public static void Main()
        {
            var counter = 0;
            var firstMatrix = new Matrix<int>(5, 4);
            for (int i = 0; i < firstMatrix.RowsCount; i++)
            {
                for (int j = 0; j < firstMatrix.ColsCount; j++)
                {
                    firstMatrix[i, j] = ++counter;
                }
            }

            Console.WriteLine(firstMatrix.ToString());

            var doubleMatrix = new Matrix<double>(4, 2);
            var decimalMatrix = new Matrix<decimal>(4, 2);
            var floatMatrix = new Matrix<float>(4, 2);
            var longMatrix = new Matrix<ulong>(4, 2);

            var secondMatrix = new Matrix<int>(5, 4);
            for (int i = 0; i < secondMatrix.RowsCount; i++)
            {
                for (int j = 0; j < secondMatrix.ColsCount; j++)
                {
                    secondMatrix[i, j] = ++counter;
                }
            }

            Console.WriteLine(secondMatrix.ToString());

            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine(firstMatrix - secondMatrix);

            var m1 = new Matrix<int>(2, 3);
            var m2 = new Matrix<int>(3, 1);

            for (int i = 0; i < m1.RowsCount; i++)
            {
                for (int j = 0; j < m1.ColsCount; j++)
                {
                    m1[i, j] = ++counter;
                }
            }

            for (int i = 0; i < m2.RowsCount; i++)
            {
                for (int j = 0; j < m2.ColsCount; j++)
                {
                    m2[i, j] = ++counter;
                }
            }

            Console.WriteLine(m1 * m2);
        }
    }
}
