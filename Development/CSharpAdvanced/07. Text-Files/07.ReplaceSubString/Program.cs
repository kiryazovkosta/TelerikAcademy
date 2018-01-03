namespace _07.ReplaceSubString
{
    using System;
    using System.IO;

    /// <summary>
    /// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file. 
    /// Ensure it will work with large files (e.g. 100 MB).
    /// </summary>
    public class ReplaceSubString
    {
        public static void Main()
        {
            string fileName = @"C:\Temp\large.txt";
            var content = File.ReadAllText(fileName);
            content = content.Replace("start", "finish");
            File.Delete(fileName);
            using (var writer = new StreamWriter(fileName))
            {
                writer.Write(content);
            }
        }
    }
}
