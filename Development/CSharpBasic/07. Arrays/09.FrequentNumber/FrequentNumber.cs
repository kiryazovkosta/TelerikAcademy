namespace _09.FrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that finds the most frequent number in an array of N elements.
    /// </summary>
    public class FrequentNumber
    {
        public static void Main()
        {
            int arraySize;
            int.TryParse(Console.ReadLine(), out arraySize);

            var numbers = new int[arraySize];
            for (int index = 0; index < numbers.GetLength(dimension: 0); index++)
            {
                int.TryParse(Console.ReadLine(), out numbers[index]);
            }

            var frequent = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (!frequent.ContainsKey(number))
                {
                    frequent.Add(number, value: 0);
                }

                frequent[number]++;
            }

            KeyValuePair<int, int> best = frequent.First();
            for (int i = 0; i < frequent.Count(); i++)
            {
                foreach (KeyValuePair<int, int> move in frequent)
                {
                    if (move.Value > best.Value)
                    {
                        best = move;
                    }
                }
            }

            Console.WriteLine($"{best.Key} ({best.Value} times)");
        }
    }
}
