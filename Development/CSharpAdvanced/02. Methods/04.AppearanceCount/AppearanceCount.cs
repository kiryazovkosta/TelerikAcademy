namespace _04.AppearanceCount
{
    using System;

    /// <summary>
    /// Write a method that counts how many times given number appears in a given array. 
    /// Write a test program to check if the method is working correctly.
    /// </summary>
    public class AppearanceCount
    {
        public static void Main()
        {
            int arraySize = 0;
            if (int.TryParse(Console.ReadLine(), out arraySize))
            {
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int number = int.Parse(Console.ReadLine());
                int counter = CountAppearanceOfNumber(numbers, number);
                Console.WriteLine(counter);
            }
        }

        private static int CountAppearanceOfNumber(int[] numbers, int number)
        {
            int counter = 0;
            for (int i = 0; i < numbers.GetLength(dimension: 0); i++)
            {
                if (numbers[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
