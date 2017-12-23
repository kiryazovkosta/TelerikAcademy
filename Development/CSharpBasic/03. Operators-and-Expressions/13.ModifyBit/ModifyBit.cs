namespace _13.ModifyBit
{
    using System;

    /// <summary>
    /// We are given an integer number N (read from the console), a bit value v (read from the console as well) (v = 0 or 1) 
    /// and a position P (read from the console). Write a sequence of operators (a few lines of C# code) 
    /// that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. 
    /// Print the resulting number on the console.
    /// </summary>
    public class ModifyBit
    {
        public static void Main()
        {
            ulong one = 1;
            ulong number = ulong.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            ulong bit = ulong.Parse(Console.ReadLine());
            if (bit == 0)
            {
                ulong mask = ~(one << position);
                ulong result = number & mask;
                Console.WriteLine(result);
            }
            else
            {
                ulong mask = one << position;
                ulong result = number | mask;
                Console.WriteLine(result);
            }
            
        }
    }
}
