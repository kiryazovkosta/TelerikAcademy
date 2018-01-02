namespace _14.WordDictionary
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A dictionary is stored as a sequence of text lines containing words and their explanations. 
    /// Write a program that enters a word and translates it by using the dictionary.
    /// </summary>
    public class WordDictionary
    {
        public static void Main()
        {
            var translates = new Dictionary<string, string>()
            {
                { ".NET", "platform for applications from Microsoft" },
                { "CLR", "managed execution environment for .NET" },
                { "namespace", "hierarchical organization of classes" }
            };

            string word = Console.ReadLine().Trim();
            Console.WriteLine(translates.ContainsKey(word) ? translates[word] : "Unknown");
        }
    }
}
