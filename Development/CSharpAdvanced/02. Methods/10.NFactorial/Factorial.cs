namespace _10.NFactorial
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Write a method that multiplies a number represented as an array of digits by a given integer number. 
    /// Write a program to calculate N!.
    /// </summary>
    public class Factorial
    {
        public static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetFactorial(number));
        }

        public static BigInteger GetFactorial(int number)
        {
            BigInteger factorial = 1;

            if (number < 0)
            {
                throw new ArgumentException("Number must be positive");
            }
            else
            {
                for (int i = 1; i <= number; ++i)
                {
                    factorial *= i;
                }
            }

            return factorial;
        }
    }
}
