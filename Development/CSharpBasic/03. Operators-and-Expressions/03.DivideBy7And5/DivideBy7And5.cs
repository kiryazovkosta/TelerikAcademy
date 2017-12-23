namespace _03.DivideBy7And5
{
    using System;

    /// <summary>
    /// Write a program that does the following:
    /// • Reads an integer number from the console.
    /// • Stores in a variable if the number can be divided by 7 and 5 without remainder.
    /// • Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. 
    /// Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.
    /// </summary>
    public class DivideBy7And5
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isDividedWithoutRemainder = (number % 7 == 0 && number % 5 == 0);
            Console.WriteLine("{0} {1}", isDividedWithoutRemainder.ToString().ToLower(), number);
        }
    }
}
