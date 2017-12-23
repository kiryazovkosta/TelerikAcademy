namespace _12.Decimal2Binary
{
    using System;

    /// <summary>
    /// Using loops write a program that converts an integer number to its binary representation.
    /// •The input is entered as long. The output should be a variable of type string.
    /// •Do not use the built-in .NET functionality.
    /// </summary>
    public class Decimal2Binary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (number & mask) + binary;
                number = number >> mask;
            }

            Console.WriteLine(binary);
        }
    }
}
