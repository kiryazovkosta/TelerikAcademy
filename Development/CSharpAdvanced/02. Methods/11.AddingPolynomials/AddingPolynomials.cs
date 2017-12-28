namespace _11.AddingPolynomials
{
    using System;

    /// <summary>
    /// Write a method that adds two polynomials. 
    /// Represent them as arrays of their coefficients. 
    /// Write a program that reads two polynomials and prints their sum.
    /// </summary>
    public class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            var first = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            var second = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            var result = AddPolynomials(size, first, second);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] AddPolynomials(int size, int[] first, int[] second)
        {
            if (first.Length != second.Length)
            {
                throw new ArgumentException("Arrays must have an equal size!");
            }

            int[] result = new int[size];
            for (int index = 0; index < size; index++)
            {
                result[index] = first[index] + second[index];
            }

            return result;
        }
    }
}
