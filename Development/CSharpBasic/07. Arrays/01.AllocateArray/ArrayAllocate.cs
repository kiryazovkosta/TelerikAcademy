namespace _01.AllocateArray
{
    using System;

    public class ArrayAllocate
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var numbers = new int[size];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                numbers[i] = i * 5;
            }

            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}
