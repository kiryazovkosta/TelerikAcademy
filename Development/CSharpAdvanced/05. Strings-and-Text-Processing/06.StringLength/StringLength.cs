namespace _06.StringLength
{
    using System;
    using System.Text;

    /// <summary>
    /// Write a program that reads from the console a string of maximum 20 characters. 
    /// If the length of the string is less than 20, the rest of the characters should be filled with *.
    /// </summary>
    public class StringLength
    {
        public static void Main()
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            while (text.Length < 20)
            {
                text.Append("*");
            }

            Console.WriteLine(text.ToString());
        }
    }
}
