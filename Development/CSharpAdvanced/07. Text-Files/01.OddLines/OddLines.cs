namespace _01.OddLines
{
    using System;
    using System.IO;

    /// <summary>
    /// Write a program that reads a text file and prints on the console its odd lines.
    /// </summary>
    public class OddLines
    {
        public static void Main()
        {
            string fileName = @"C:\Temp\Installed-Software.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    counter++;
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
