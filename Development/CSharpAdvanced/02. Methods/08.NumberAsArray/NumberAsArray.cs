namespace _08.NumberAsArray
{
    using System;

    /// <summary>
    /// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
    /// the last digit is kept in arr[0]). 
    /// Write a program that reads two arrays representing positive integers and outputs their sum.
    /// </summary>
    public class NumberAsArray
    {
        public static void Main()
        {
            int[] sizes = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            int firstSize = sizes[0];
            int secondSize = sizes[1];
            int one = 0;

            int[] result = new int[Math.Max(firstSize, secondSize) + 1];
            int[] firstNumbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
            int[] secondNumbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));

            for (int i = 0; i < Math.Min(firstSize, secondSize); i++)
            {
                result[i] = (firstNumbers[i] + secondNumbers[i] + one) % 10;
                one = (firstNumbers[i] + secondNumbers[i] + one) / 10;
            }

            if (firstSize > secondSize)
            {
                for (int i = secondSize; i < firstSize; i++)
                {
                    result[i] = (firstNumbers[i] + one) % 10;
                    one = (firstNumbers[i] + one) / 10;
                }
            }
            else if (secondSize > firstSize)
            {
                for (int i = firstSize; i < secondSize; i++)
                {
                    result[i] = (secondNumbers[i] + one) % 10;
                    one = (secondNumbers[i] + one) / 10;
                }
            }

            result[Math.Max(firstSize, secondSize)] = one;
            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 == length)
                {
                    if (result[i] == 0)
                    {
                        continue;
                    }
                }

                Console.Write(result[i] + " ");
            }
        }
    }
}