namespace _07.ReverseNumber
{
    using System;

    /// <summary>
    /// Write a method that reverses the digits of a given decimal number.
    /// </summary>
    public class ReverseNumber
    {
        public static void Main()
        {
            var number = Console.ReadLine().ToCharArray();
            Array.Reverse(number);
            Console.WriteLine(new string(number));
        }
    }
}
