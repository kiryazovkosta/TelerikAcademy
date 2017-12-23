namespace _07.Calculate3_
{
    using System;
    using System.Numerics;

    /// <summary>
    /// In combinatorics, the number of ways to choose N different members out of a group of N different 
    /// elements (also known as the number of combinations) is calculated by the following formula: formula 
    /// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.0
    /// Your task is to write a program that calculates  N! / (K! * (N - K)!)  for given N and K. 
    /// </summary>
    public class Calculate3_
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int d = n - k;

            BigInteger productN = 1;
            BigInteger productK = 1;
            BigInteger productD = 1;

            for (int i = 2; i <= n; i++)
            {
                productN *= i;
                if (i <= k)
                {
                    productK = productN;
                }
                if (i <= d)
                {
                    productD = productN;
                }
            }

            Console.WriteLine(productN / (productK * productD));
        }
    }
}
