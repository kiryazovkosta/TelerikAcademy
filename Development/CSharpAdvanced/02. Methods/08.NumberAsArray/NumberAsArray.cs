namespace _08.NumberAsArray
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
    /// Write a program that reads two arrays representing positive integers and outputs their sum.
    /// </summary>
    public class NumberAsArray
    {
        public static void Main()
        {
            var separator = new char[] { ' ' };
            int[] arraySizes = Array.ConvertAll(Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            var firstArray = new int[arraySizes[0]];
            var secondArray = new int[arraySizes[1]];

            char[] firstArrayMemebers = Console.ReadLine().Replace(oldValue: " ", newValue: string.Empty).ToCharArray();
            char[] secondArrayMembers = Console.ReadLine().Replace(oldValue: " ", newValue: string.Empty).ToCharArray();

            Array.Reverse(firstArrayMemebers);
            Array.Reverse(secondArrayMembers);

            BigInteger firstNumber, secondNumber;
            BigInteger.TryParse(new string(firstArrayMemebers), out firstNumber);
            BigInteger.TryParse(new string(secondArrayMembers), out secondNumber);

            firstNumber = BigInteger.Add(firstNumber, secondNumber);
            char[] result = firstNumber.ToString().ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(string.Join(separator: " ", values: result));
        }
    }
}