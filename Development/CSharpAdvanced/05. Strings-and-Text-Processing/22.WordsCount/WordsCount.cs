namespace _22.WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads a string from the console and 
    /// lists all different words in the string along with information how many times each word is found.
    /// </summary>
    public class WordsCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            char[] separators = text.Where(c => !char.IsLetter(c)).Distinct().ToArray();
            var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            foreach (var record in wordsCount)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }
    }
}
