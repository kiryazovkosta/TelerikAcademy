namespace _02.BonusScore
{
    using System;

    /// <summary>
    /// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    /// • If the score is between 1 and 3, the program multiplies it by 10.
    /// • If the score is between 4 and 6, the program multiplies it by 100.
    /// • If the score is between 7 and 9, the program multiplies it by 1000.
    /// • If the score is less than 0 or more than 9, the program prints "invalid score".
    /// </summary>
    public class BonusScore
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 3)
            {
                int result = number * 10;
                Console.WriteLine(result);
            }
            else if (number >= 4 && number <= 6)
            {
                int result = number * 100;
                Console.WriteLine(result);
            }
            else if (number >= 7 && number <= 9)
            {
                int result = number * 1000;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
