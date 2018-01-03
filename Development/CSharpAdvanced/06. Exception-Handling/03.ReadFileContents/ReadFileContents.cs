namespace _03.ReadFileContents
{
    using System;
    using System.IO;

    /// <summary>
    /// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
    /// Find in MSDN how to use System.IO.File.ReadAllText(...). 
    /// Be sure to catch all possible exceptions and print user-friendly error messages.
    /// </summary>
    public class ReadFileContents
    {
        public static void Main()
        {
            var fileName = @"C:\WINDOWS\win.ini";
            try
            {
                var content = File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException fnfException)
            {
                Console.WriteLine(fnfException.Message);
            }
            catch (IOException ioException)
            {
                Console.WriteLine(ioException.Message);
            }
        }
    }
}
