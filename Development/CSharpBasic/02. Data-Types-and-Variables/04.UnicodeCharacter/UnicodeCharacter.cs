namespace _04.UnicodeCharacter
{
    using System;

    /// <summary>
    /// Declare a character variable and assign it with the symbol that has Unicode code  42  (decimal) 
    /// using the  \u00XX  syntax, and then print it.
    /// </summary>
    public class UnicodeCharacter
    {
        public static void Main()
        {
            char c = '\u002A';
            Console.WriteLine(c);
        }
    }
}
