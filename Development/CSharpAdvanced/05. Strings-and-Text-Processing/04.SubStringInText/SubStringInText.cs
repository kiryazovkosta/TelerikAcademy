namespace _04.SubStringInText
{
    using System;

    /// <summary>
    /// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
    /// </summary>
    public class SubStringInText
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            int counter = 0;
            int index = text.IndexOf(pattern, 0, StringComparison.CurrentCultureIgnoreCase);
            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1, StringComparison.CurrentCultureIgnoreCase);
            }

            Console.WriteLine(counter);
        }
    }
}
