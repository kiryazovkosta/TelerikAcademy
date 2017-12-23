namespace _11._3rdBit
{
    using System;

    /// <summary>
    /// Using bitwise operators, write a program that uses an expression to find 
    /// the value of the bit at index 3 of an unsigned integer read from the console.
    ///     •The bits are counted from right to left, starting from bit 0.
    ///     •The result of the expression should be either 1 or 0. Print it on the console.

    /// </summary>
    public class ThirrdBit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = 3;
            int one = 1;
            int mask = one << position;
            int nAndMask = number & mask;
            int bit = nAndMask >> position;
            Console.WriteLine(bit);
        }
    }
}