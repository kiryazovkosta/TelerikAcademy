namespace _10.UnicodeCharacters
{
    using System;
    using System.Text;

    /// <summary>
    /// Write a program that converts a string to a sequence of C# Unicode character literals.
    /// </summary>
    public class UnicodeCharacters
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetUnicodeString(text));
        }

        public static string GetUnicodeString(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Append("\\u" + ((int)c).ToString("X").PadLeft(4, '0'));
            }
            return sb.ToString();
        }
    }
}
