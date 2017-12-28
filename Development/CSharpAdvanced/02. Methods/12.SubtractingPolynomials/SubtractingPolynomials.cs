namespace _12.SubtractingPolynomials
{
    using System;

    /// <summary>
    /// Extend the previous program to support also subtraction and multiplication of polynomials.
    /// </summary>
    public class SubtractingPolynomials
    {
        public static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            var first = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            var second = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            var subtractionResult = SubtractPolynomials(size, first, second);
            Console.WriteLine(string.Join(" ", subtractionResult));
            var multiplicationResult = MultiplyPolynomials(size, first, second);
            Console.WriteLine(string.Join(" ", multiplicationResult));
        }

        public static int[] SubtractPolynomials(int size, int[] first, int[] second)
        {
            if (first.Length != second.Length)
            {
                throw new ArgumentException("Arrays must have an equal size!");
            }

            int[] result = new int[size];
            for (int index = 0; index < size; index++)
            {
                result[index] = first[index] - second[index];
            }

            return result;
        }

        public static long[] MultiplyPolynomials(int size, int[] first, int[] second)
        {
            if (first.Length != second.Length)
            {
                throw new ArgumentException("Arrays must have an equal size!");
            }

            long[] result = new long[size];
            for (int index = 0; index < size; index++)
            {
                result[index] = first[index] * second[index];
            }

            return result;
        }
    }
}
