namespace _03.EnglishDigit
{
    using System;

    /// <summary>
    /// Write a method that returns the last digit of given integer as an English word. 
    /// Write a program that reads a number and prints the result of the method.
    /// </summary>
    public class EnglishDigit
    {
        public static void Main()
        {
            int number = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out number);
            if (isValid)
            {
                int lastDigit = number % 10;
                string lastDigitWord = GetDigitAsWord(lastDigit);
                Console.WriteLine(lastDigitWord);
            }
        }

        private static string GetDigitAsWord(int digit)
        {
            string digitAsWord = string.Empty;

            if (digit > 9)
            {
                digit = digit % 10;
            }

            if (digit < 0)
            {
                digit = digit * -1;
            }

            switch (digit)
            {
                case 0:
                    digitAsWord = "zero";
                    break;

                case 1:
                    digitAsWord = "one";
                    break;

                case 2:
                    digitAsWord = "two";
                    break;

                case 3:
                    digitAsWord = "three";
                    break;

                case 4:
                    digitAsWord = "four";
                    break;

                case 5:
                    digitAsWord = "five";
                    break;

                case 6:
                    digitAsWord = "six";
                    break;

                case 7:
                    digitAsWord = "seven";
                    break;

                case 8:
                    digitAsWord = "eight";
                    break;

                case 9:
                    digitAsWord = "nine";
                    break;


                default:
                    digitAsWord = "not a digit";
                    break;
            }

            return digitAsWord;
        }
    }
}
