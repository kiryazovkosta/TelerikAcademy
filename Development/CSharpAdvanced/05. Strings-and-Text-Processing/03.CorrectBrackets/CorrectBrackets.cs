namespace _03.CorrectBrackets
{
    using System;

    /// <summary>
    /// Write a program to check if in a given expression the ( and ) brackets are put correctly.
    /// </summary>
    public class CorrectBrackets
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            int openBrackets = 0;
            int closeBrackets = 0;

            foreach (var symbol in input)
            {
                if (symbol == '(')
                {
                    openBrackets++;
                }
                else if (symbol == ')')
                {
                    closeBrackets++;
                }
            }

            Console.WriteLine(openBrackets == closeBrackets ? "Correct" : "Incorrect");
        }
    }
}
