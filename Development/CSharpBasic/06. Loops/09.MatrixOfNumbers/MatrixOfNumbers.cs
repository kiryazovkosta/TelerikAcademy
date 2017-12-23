namespace _09.MatrixOfNumbers
{
    using System;
    using System.Collections.Generic;

    public class MatrixOfNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                var numbers = new List<int>();
                for (int j = i + 1; j <= number + i; j++)
                {
                    numbers.Add(j);
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
