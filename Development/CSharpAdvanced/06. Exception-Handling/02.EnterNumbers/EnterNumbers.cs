namespace _02.EnterNumbers
{
    using System;

    /// <summary>
    /// Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
    /// If an invalid number or non-number text is entered, the method should throw an exception.
    /// Using this method write a program that enters 10 numbers:	a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
    /// </summary>
    public class EnterNumbers
    {
        public static void Main()
        {
            int[] numbers = new int[10];

            try
            {
                ReadNumbers(numbers);
                ValidateNumbers(numbers);
                Console.WriteLine(string.Format("1 < {0} < 100", string.Join(" < ", numbers)));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Exception");
            }
        }

        public static bool ReadNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isValid = int.TryParse(Console.ReadLine(), out numbers[i]);
                if (!isValid)
                {
                    throw new ArgumentException($"Invalid integer number at index {i}");
                }
            }

            return true;
        }

        public static bool ValidateNumbers(int[] numbers)
        {
            if (numbers[0] <= 1)
            {
                throw new ArgumentException("First element of the array mest be greater then 1!");
            }

            if (numbers[numbers.Length - 1] >= 100)
            {
                throw new ArgumentException("Last element of the array mest be smaller then 100!");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                bool isValid = numbers[i] > numbers[i - 1];
                if (!isValid)
                {
                    throw new ArgumentException($"Invalid integer number at index {i}");
                }
            }

            return true;
        }
    }
}
