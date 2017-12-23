namespace _12.IndexOfLetters
{
    using System;

    /// <summary>
    /// Write a program that creates an array containing all letters from the alphabet (a-z). 
    /// Read a word from the console and print the index of each of its letters in the array.
    /// </summary>
    class IndexOfLetters
    {
        public static void Main()
        {
            char begin = 'a';
            char end = 'z';
            var symbols = new int[26];
            for (int i = begin, index = 0; i < end; i++, index++)
            {
                symbols[index] = i;
            }

            char[] wordLetters = Console.ReadLine().ToCharArray();
            for (int i = 0; i < wordLetters.GetLength(dimension: 0); i++)
            {
                for (int j = 0; j < symbols.GetLength(dimension: 0); j++)
                {
                    if (wordLetters[i] == symbols[j])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}
