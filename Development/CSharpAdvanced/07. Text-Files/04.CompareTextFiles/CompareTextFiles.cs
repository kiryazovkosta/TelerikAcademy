namespace _04.CompareTextFiles
{
    using System;
    using System.IO;

    /// <summary>
    /// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. 
    /// Assume the files have equal number of lines. 
    /// </summary>
    public class CompareTextFiles
    {
        public static void Main()
        {
            string first = @"C:\Temp\first.txt";
            string second = @"C:\Temp\second.txt";

            int equalCounter = 0;
            int differentCounter = 0;

            using (var firstReader = new StreamReader(first))
            {
                using (var secondReader = new StreamReader(second))
                {
                    var firstLine = firstReader.ReadLine();
                    var secondLine = secondReader.ReadLine();

                    while (firstLine != null && secondLine != null)
                    {
                        if (firstLine == secondLine)
                        {
                            equalCounter++;
                        }
                        else
                        {
                            differentCounter++;
                        }

                        firstLine = firstReader.ReadLine();
                        secondLine = secondReader.ReadLine();
                    }
                }
            }

            Console.WriteLine($"Number of equals lines {equalCounter}");
            Console.WriteLine($"Number of different lines {differentCounter}");
        }
    }
}
