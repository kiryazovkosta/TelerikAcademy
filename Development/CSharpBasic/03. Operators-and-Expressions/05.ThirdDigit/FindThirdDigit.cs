namespace _05.ThirdDigit
{
    using System;

    /// <summary>
    /// Write a program that reads an integer N from the console and prints true if the third digit of the N is 7, 
    /// or "false THIRD_DIGIT", where you should print the third digits of N.
    /// </summary>
    public class FindThirdDigit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int a = number / 100;
            int b = a % 10;
            if (b == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", b);
            }
        }
    }
}