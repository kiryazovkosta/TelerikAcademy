namespace _06.SaveSortedNames
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SaveSortedNames
    {
        public static void Main()
        {
            string inputFile = @"C:\Temp\input.txt";
            string outputFile = @"C:\Temp\output.txt";

            using (var reader = new StreamReader(inputFile))
            {
                var names = new List<string>();
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line);
                }

                names.Sort();

                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }

                using (var writer = new StreamWriter(outputFile))
                {
                    writer.Write(string.Join(Environment.NewLine, names));
                }
            }
        }
    }
}
