namespace _14.PrinttheASCIITable
{
    using System;

    /// <summary>
    /// Find online more information about ASCII (American Standard Code for Information Interchange) 
    /// and write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).
    /// </summary>
    public class ASCIITable
    {
        public static void Main()
        {
            int beginCharacterIndex = 33;
            int endCharacterIndex = 126;
            for (int i = beginCharacterIndex; i <= endCharacterIndex; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}