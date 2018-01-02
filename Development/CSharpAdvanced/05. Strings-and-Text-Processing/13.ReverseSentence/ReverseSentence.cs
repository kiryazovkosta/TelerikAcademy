namespace _13.ReverseSentence
{
    using System;

    /// <summary>
    /// Write a program that reverses the words in a given sentence.
    /// </summary>
    public class ReverseSentence
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
