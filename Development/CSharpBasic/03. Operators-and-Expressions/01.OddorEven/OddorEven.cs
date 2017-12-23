namespace _01.OddorEven
{
    using System;
    using System.Text;

    /// <summary>
    /// Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, 
    /// and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.
    /// </summary>
    public class OddorEven
    {
        public static void Main()
        {
            var number = sbyte.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(string.Format("even {0}", number));
            }
            else
            {
                Console.WriteLine(string.Format("odd {0}", number));
            }
        }
    }
}
