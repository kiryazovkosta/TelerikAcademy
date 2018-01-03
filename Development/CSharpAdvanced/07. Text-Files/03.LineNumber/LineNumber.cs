namespace _03.LineNumber
{
    using System.IO;

    /// <summary>
    /// Write a program that reads a text file and inserts line numbers in front of each of its lines. 
    /// The result should be written to another text file.
    /// </summary>
    public class LineNumber
    {
        public static void Main()
        {
            string fileName = @"C:\Temp\first.txt";
            string resultName = @"C:\Temp\line.txt";

            if (File.Exists(resultName))
            {
                File.Delete(resultName);
            }

            using (var reader = new StreamReader(fileName))
            {
                using (var writer = new StreamWriter(resultName))
                {
                    int lineCounter = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineCounter++;
                        writer.WriteLine($"{lineCounter}{line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
