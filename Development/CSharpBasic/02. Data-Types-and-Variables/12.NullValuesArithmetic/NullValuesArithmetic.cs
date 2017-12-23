namespace _12.NullValuesArithmetic
{
    using System;

    /// <summary>
    /// Create a program that assigns null values to an integer and to a double variable. 
    /// •Try to print these variables at the console.
    /// •Try to add some number or the null literal to these variables and print the result.
    /// </summary>
    public class NullValuesArithmetic
    {
        public static void Main()
        {
            int? i = 2;
            double? d = 10.2;
            Console.WriteLine("i? -> {0}", i);
            Console.WriteLine("d? -> {0}", d);

            i = 5;
            d = null;
            Console.WriteLine("i? -> {0}", i);
            Console.WriteLine("d? -> {0}", d);
        }
    }
}
