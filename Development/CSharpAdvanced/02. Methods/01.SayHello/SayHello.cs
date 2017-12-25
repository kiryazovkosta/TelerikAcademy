namespace _01.SayHello
{
    using System;

    /// <summary>
    /// Write a method that asks the user for his name and prints Hello, <name>!. 
    /// Write a program to test this method.
    /// </summary>
    public class SayHello
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name: name);
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}