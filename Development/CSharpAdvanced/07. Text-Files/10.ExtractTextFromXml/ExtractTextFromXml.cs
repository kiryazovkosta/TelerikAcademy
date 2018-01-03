namespace _10.ExtractTextFromXml
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    /// <summary>
    /// Write a program that extracts from given XML file all the text without the tags.
    /// </summary>
    public class ExtractTextFromXml
    {
        public static void Main()
        {
            string file = @"C:\Temp\EXC001BG_BGNCA00165003_3081_20171214.xml";
            Regex regex = new Regex(">(.+?)<");
            var matchs = regex.Matches(File.ReadAllText(file));
            foreach (Match match in matchs)
            {
                Console.WriteLine(match.Value.Replace("<", "").Replace(">", ""));
            }
        }
    }
}
