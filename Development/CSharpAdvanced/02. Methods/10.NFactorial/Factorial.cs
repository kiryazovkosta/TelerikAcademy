using System;
using System.Numerics;

namespace _10.NFactorial
{
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
