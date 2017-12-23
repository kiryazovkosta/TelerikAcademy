namespace _06.MaximalKSum
{
    using System;

    /// <summary>
    /// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
    /// Find the maximal sum of K elements in the array.
    /// </summary>
    public class MaximalKSum
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int elementCount = int.Parse(Console.ReadLine());

            var numbers = new int[arraySize];
            for (int index = 0; index < numbers.GetLength(dimension: 0); index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            long sum = 0;
            for (int i = arraySize - elementCount; i < numbers.GetLength(dimension: 0); i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}