namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IEnumerableExtensionsDemo
    {
        public static void Main()
        {
            var list = new List<int>() {1, 2, 3, 4, 10, 5, 6, 7, 8 };
            var numbers = new List<double>() { 1.05, 2.11, 3.87, 4.14, 9.00, 5.55, 6.13, 7.93, 8.61 };

            Console.WriteLine("Sum");
            Console.WriteLine(list.Sum());
            Console.WriteLine(numbers.Sum());

            Console.WriteLine("Product");
            Console.WriteLine(list.Product());
            Console.WriteLine(numbers.Product());

            Console.WriteLine("Min");
            Console.WriteLine(list.Min());
            Console.WriteLine(numbers.Min());

            Console.WriteLine("Max");
            Console.WriteLine(list.Max());
            Console.WriteLine(numbers.Max());

            Console.WriteLine("Average");
            Console.WriteLine(list.Average().ToString("F3"));
            Console.WriteLine(numbers.Average().ToString("F3"));
        }
    }
}
