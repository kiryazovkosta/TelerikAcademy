namespace _02.ConcatenateTextFiles
{
    using System;
    using System.IO;

    /// <summary>
    /// 02. Write a program that concatenates two text files into another text file.
    /// </summary>
    public class ConcatenateTextFiles
    {
        public static void Main()
        {
            string firstFile = @"C:\Temp\first.txt";
            string secondFile = @"C:\Temp\second.txt";

            string resultFile = @"C:\Temp\result.txt";
            if (File.Exists(resultFile))
            {
                File.Delete(resultFile);
            }

            using (var writer = new StreamWriter(resultFile))
            {
                using (var reader = new StreamReader(firstFile))
                {
                    writer.WriteLine(reader.ReadToEnd());
                }

                using (var reader = new StreamReader(secondFile))
                {
                    writer.WriteLine(reader.ReadToEnd());
                }
            }
        }
    }
}
