namespace _08.CatalanNumbers
{
    using System;
    using System.Numerics;
    /// <summary>
    /// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    /// • Write a program to calculate the Nth Catalan number by given N
    /// </summary>
    public class CatalanNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger productN = 1;
            BigInteger productN1 = 1;
            BigInteger product2N = 1;

            for (int i = 2; i <= 2*n; i++)
            {
                product2N *= i;
                if (i <= n)
                {
                    productN = product2N;
                }
                if (i <= n + 1)
                {
                    productN1 = product2N;
                }
            }

            Console.WriteLine(product2N / (productN1 * productN));
        }
    }
}
