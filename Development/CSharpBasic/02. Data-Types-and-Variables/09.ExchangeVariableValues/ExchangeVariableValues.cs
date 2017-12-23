namespace _09.ExchangeVariableValues
{
    using System;

    /// <summary>
    /// Declare two integer variables  a  and  b  and assign them with  5  and  10  and after that exchange their values 
    /// by using some programming logic. Print the variable values before and after the exchange.
    /// </summary>
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a -> {0}", a);
            Console.WriteLine("b -> {0}", b);

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a -> {0}", a);
            Console.WriteLine("b -> {0}", b);
        }
    }
}
