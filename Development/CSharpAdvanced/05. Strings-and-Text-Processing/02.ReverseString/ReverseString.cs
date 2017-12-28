namespace _02.ReverseString
{
    using System;

    /// <summary>
    /// Write a program that reads a string, reverses it and prints the result on the console.
    /// </summary>
    public class ReverseString
    {
        public static void Main()
        {
            var inputText = Console.ReadLine().ToCharArray();
            var reverseText = new char[inputText.Length];
            for (int i = inputText.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reverseText[j] = inputText[i];
            }

            Console.WriteLine(string.Join(string.Empty, reverseText));
        }
    }
}
