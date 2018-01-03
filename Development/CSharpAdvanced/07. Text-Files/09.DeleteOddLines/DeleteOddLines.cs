namespace _09.DeleteOddLines
{
    using System.IO;
    using System.Text;

    /// <summary>
    /// Write a program that deletes from given text file all odd lines. The result should be in the same file.
    /// </summary>
    public class DeleteOddLines
    {
        public static void Main()
        {
            var input = @"C:\Temp\file.txt";
            StringBuilder evedLinesOnlyText = new StringBuilder();

            using (var reader = new StreamReader(input))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        evedLinesOnlyText.AppendLine(line);
                    }

                    line = reader.ReadLine();
                }
            }

            if (File.Exists(input))
            {
                File.Delete(input);
            }

            using (var writer = new StreamWriter(input))
            {
                writer.WriteLine(evedLinesOnlyText.ToString());
            }
        }
    }
}
