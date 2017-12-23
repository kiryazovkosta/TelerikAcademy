namespace _06.CalculateAgain_
{
    using System;
    using System.Numerics;
    /// <summary>
    /// Write a program that calculates N! / K! for given N and K.
    /// </summary>
    public class CalculateAgain_
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger productN = 1;
            BigInteger productK = 1;

            for (int i = 2; i <= n; i++)
            {
                if (i <= k)
                {
                    productK *= i;
                    productN = productK;
                }
                else
                {
                    productN *= i;
                }
            }

            Console.WriteLine(productN / productK);
        }
    }
}