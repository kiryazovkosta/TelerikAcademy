namespace _07.SelectionSort
{
    using System;
    using System.Linq;

    /// <summary>
    /// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
    /// Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
    /// find the smallest from the rest, move it at the second position, etc.
    /// </summary>
    public class SelectionSort
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());

            var numbers = new int[arraySize];
            for (int index = 0; index < numbers.GetLength(dimension: 0); index++)
            {
                int.TryParse(Console.ReadLine(), out numbers[index]);
            }

            for (int i = 0; i < numbers.GetLength(dimension: 0); i++)
            {
                int s = i;

                for (int j = i + 1; j < numbers.GetLength(dimension: 0); j++)
                {
                    if (numbers[s] > numbers[j])
                    {
                        s = j;
                    }   
                }

                if (i != s)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[s];
                    numbers[s] = temp;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}