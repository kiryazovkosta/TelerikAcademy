namespace _12.N_thBit
{
    using System;

    /// <summary>
    /// Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit. 
    /// </summary>
    public class NthBit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int one = 1;
            long mask = one << position;
            long nAndMask = number & mask;
            long bit = nAndMask >> position;
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(bit);
        }
    }
}
