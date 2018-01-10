namespace _08.Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
    /// Implement an indexer this[row, col] to access the inner matrix cells.
    /// Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
    /// Throw an exception when the operation cannot be performed.
    /// Implement the true operator (check for non-zero elements).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T>
        where T : struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
    {
        private readonly int rowsCount;

        private readonly int colsCount;

        private T[,] elements;

        public Matrix(int rows, int cols)
        {
            if (rows <= 0)
            {
                throw new ArgumentException(nameof(this.rowsCount));
            }

            if (cols <= 0)
            {
                throw new ArgumentException(nameof(this.colsCount));
            }

            this.elements = new T[rows, cols];
            this.rowsCount = rows;
            this.colsCount = cols;
        }

        public int RowsCount
        {
            get
            {
                return this.rowsCount;
            }
        }

        public int ColsCount
        {
            get
            {
                return this.colsCount;
            }
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= this.RowsCount)
                {
                    throw new IndexOutOfRangeException(nameof(rowIndex));
                }

                if (colIndex < 0 || colIndex >= this.ColsCount)
                {
                    throw new IndexOutOfRangeException(nameof(colIndex));
                }

                return this.elements[rowIndex, colIndex];
            }

            set
            {
                if (rowIndex < 0 || rowIndex >= this.RowsCount)
                {
                    throw new IndexOutOfRangeException(nameof(rowIndex));
                }

                if (colIndex < 0 || colIndex >= this.ColsCount)
                {
                    throw new IndexOutOfRangeException(nameof(colIndex));
                }

                this.elements[rowIndex, colIndex] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.RowsCount != secondMatrix.RowsCount
                || firstMatrix.ColsCount != secondMatrix.ColsCount)
            {
                throw new ArgumentException("Matrix are not with the same size ");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.RowsCount, firstMatrix.ColsCount);
            for (int rowIndex = 0; rowIndex < firstMatrix.RowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < firstMatrix.ColsCount; colIndex++)
                {
                    result[rowIndex, colIndex] = (dynamic)firstMatrix[rowIndex, colIndex] + (dynamic)secondMatrix[rowIndex, colIndex];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.RowsCount != secondMatrix.RowsCount
                || firstMatrix.ColsCount != secondMatrix.ColsCount)
            {
                throw new ArgumentException("Matrix are not with the same size ");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.RowsCount, firstMatrix.ColsCount);
            for (int rowIndex = 0; rowIndex < firstMatrix.RowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < firstMatrix.ColsCount; colIndex++)
                {
                    result[rowIndex, colIndex] = (dynamic)firstMatrix[rowIndex, colIndex] - (dynamic)secondMatrix[rowIndex, colIndex];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.ColsCount != secondMatrix.RowsCount)
            {
                throw new ArgumentException("Matrix has different row and col size");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.RowsCount, secondMatrix.ColsCount);
            for (int rowIndex = 0; rowIndex < firstMatrix.RowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < secondMatrix.ColsCount; colIndex++)
                {
                    dynamic sum = 0;
                    for (int i = 0; i < firstMatrix.ColsCount; i++)
                    {
                        sum += (dynamic)firstMatrix[rowIndex, i] * (dynamic)secondMatrix[i, colIndex];
                    }

                    result[rowIndex, colIndex] = sum;
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.RowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.ColsCount; colIndex++)
                {
                    if ((dynamic)matrix[rowIndex, colIndex] != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.RowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.ColsCount; colIndex++)
                {
                    if ((dynamic)matrix[rowIndex, colIndex] != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int rowIndex = 0; rowIndex < this.RowsCount; rowIndex++)
            {
                sb.Append("[");
                for (int colIndex = 0; colIndex < this.ColsCount; colIndex++)
                {
                    sb.Append(this.elements[rowIndex, colIndex]);
                    if (colIndex < this.ColsCount - 1)
                    {
                        sb.Append(", ");
                    }
                }

                sb.AppendLine("]");
            }

            return sb.ToString();
        }
    }
}
