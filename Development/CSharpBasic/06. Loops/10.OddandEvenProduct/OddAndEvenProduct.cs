namespace _10.OddandEvenProduct
{
    using System;

    public class OddAndEvenProduct
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' });

            ulong oddProduction = 1;
            ulong evenProduction = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduction *= (ulong)int.Parse(numbers[i]);
                }
                else
                {
                    evenProduction *= (ulong)int.Parse(numbers[i]);
                }
            }

            if (oddProduction == evenProduction)
            {
                Console.WriteLine(string.Format("yes {0}", oddProduction));
            }
            else
            {
                Console.WriteLine(string.Format("no {0} {1}", oddProduction, evenProduction));
            }
        }
    }
}
