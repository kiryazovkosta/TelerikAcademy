namespace _21.LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads a string from the console and 
    /// prints all different letters in the string along with information how many times each letter is found.
    /// </summary>
    public class LettersCount
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            char[] separators = text.Where(c => !char.IsLetter(c)).Distinct().ToArray();

            var lettersCount = new Dictionary<char, int>();
            foreach (var letter in text)
            {
                if (!char.IsLetter(letter))
                {
                    continue;
                }

                if (lettersCount.ContainsKey(letter))
                {
                    lettersCount[letter]++;
                }
                else
                {
                    lettersCount[letter] = 1;
                }
            }

            foreach (var record in lettersCount)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }
    }
}
