namespace _05.ParseTags
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    /// </summary>
    public class ParseTags
    {
        private const string OpenTag = "<upcase>";
        private const string CloseTag = "</upcase>";

        public static void Main()
        {
            string text = Console.ReadLine();
            var replaceItems = new Dictionary<string, string>();

            int openTagIndex = text.IndexOf(OpenTag, 0);
            while (openTagIndex != -1)
            {
                int closeTagIndex = text.IndexOf(CloseTag, openTagIndex);
                var oldValue = text.Substring(openTagIndex, closeTagIndex - openTagIndex + CloseTag.Length);
                var newValue = oldValue.Substring(OpenTag.Length, oldValue.Length - OpenTag.Length - OpenTag.Length - 1).ToUpper();
                if (!replaceItems.ContainsKey(oldValue))
                {
                    replaceItems.Add(oldValue, newValue);
                }

                openTagIndex = text.IndexOf(OpenTag, closeTagIndex + CloseTag.Length);
            }

            foreach (var item in replaceItems)
            {
                text = text.Replace(item.Key, item.Value);
            }

            Console.WriteLine(text);
        }
    }
}
