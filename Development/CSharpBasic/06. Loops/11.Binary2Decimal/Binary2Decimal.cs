namespace _11.Binary2Decimal
{
    using System;

    /// <summary>
    /// Using loops write a program that converts a binary integer number to its decimal form.
    /// •The input is entered as string. The output should be a variable of type long.
    /// •Do not use the built-in .NET functionality.
    /// </summary>
    public class Binary2Decimal
    {
        public static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string numberAsBinary = Console.ReadLine();

            int counter = 0;
            int number = 0;
            for (int index = numberAsBinary.Length - 1; index >= 0; index--)
            {
                if (numberAsBinary[index] == '1')
                {
                    number += (int)Math.Pow(2, counter);
                }

                counter++;
            }

            Console.WriteLine(number);
        }
    }
}
