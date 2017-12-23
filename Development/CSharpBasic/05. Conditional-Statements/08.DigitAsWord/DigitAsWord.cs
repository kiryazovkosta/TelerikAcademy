namespace _08.DigitAsWord
{
    using System;

    /// <summary>
    /// Write a program that read a digit (0-9) from the console, and depending on the input, shows the digit as a word (in English).
    /// • Print "not a digit" in case of invalid input.
    /// • Use a switch statement.
    /// </summary>
    public class DigitAsWord
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            switch (input)
            {
                case "0":
                    output = "zero";
                    break;
                case "1":
                    output = "one";
                    break;
                case "2":
                    output = "two";
                    break;
                case "3":
                    output = "three";
                    break;
                case "4":
                    output = "four";
                    break;
                case "5":
                    output = "five";
                    break;
                case "6":
                    output = "six";
                    break;
                case "7":
                    output = "seven";
                    break;
                case "8":
                    output = "eight";
                    break;
                case "9":
                    output = "nine";
                    break;
                default:
                    output = "not a digit";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
