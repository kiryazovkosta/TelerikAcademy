namespace _04.MaximalSequence
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
    /// </summary>
    public class MaximalSequence
    {
        public static readonly int One = 1;
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = new int[arraySize];
            for (int index = 0; index < arraySize; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }

            int maxLength = One;
            int currentLength = One;
            for (int index = 1; index < arraySize; index++)
            {
                if (numbers[index] == numbers[index- 1])
                {
                    currentLength++;
                }
                else
                {
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                    }

                    currentLength = One;
                }

                if (index == arraySize - 1 && maxLength < currentLength)
                {
                    maxLength = currentLength;
                    currentLength = One;
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}
