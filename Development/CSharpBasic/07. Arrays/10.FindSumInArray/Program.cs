namespace _10.FindSumInArray
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that finds in given array of integers a sequence of given sum S (if present).
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            string[] numbersAsStringArray = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[numbersAsStringArray.GetLength(dimension: 0)];

            for (int index = 0; index < numbersAsStringArray.GetLength(dimension: 0); index++)
            {
                numbers[index] = int.Parse(numbersAsStringArray[index]);
            }

            int sum = int.Parse(Console.ReadLine());
            bool foundSum = false;

            for (int i = 0; i < numbers.GetLength(dimension: 0); i++)
            {
                int currentSum = numbers[i];

                for (int j = i + 1; j < numbers.GetLength(dimension: 0); j++)
                {
                    currentSum += numbers[j];
                    if (currentSum == sum)
                    {
                        foundSum = true;
                    }
                    else if (currentSum > sum)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(foundSum);
        }
    }
}
