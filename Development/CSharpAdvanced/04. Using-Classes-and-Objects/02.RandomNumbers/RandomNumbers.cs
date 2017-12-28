namespace _02.RandomNumbers
{
    using System;

    /// <summary>
    /// Write a program that generates and prints to the console 10 random values in the range [100, 200].
    /// </summary>
    public class RandomNumbers
    {
        public static void Main()
        {
            Random random = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = random.Next(100, 200);
                Console.WriteLine($"{number:D2} -> {randomNumber}");
            }
        }
    }
}
