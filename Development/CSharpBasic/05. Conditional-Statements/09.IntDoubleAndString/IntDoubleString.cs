namespace _09.IntDoubleAndString
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write a program that, depending on the first line of the input, reads an int, double or string variable.
    /// • If the variable is int or double, the program increases it by one.
    /// • If the variable is a string, the program appends* at the end.
    /// • Print the result at the console. Use switch statement.
    /// </summary>
    public class IntDoubleString
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string inputType = Console.ReadLine();
            switch (inputType)
            {
                case "integer":
                    int integerValue = int.Parse(Console.ReadLine());
                    integerValue++;
                    Console.WriteLine(integerValue);
                    break;

                case "real":
                    double inputValue = double.Parse(Console.ReadLine());
                    inputValue++;
                    Console.WriteLine("{0:f2}", inputValue);
                    break;

                case "text":
                    Console.WriteLine(string.Format("{0}*", Console.ReadLine()));
                    break;

                default:
                    break;
            }
        }
    }
}
