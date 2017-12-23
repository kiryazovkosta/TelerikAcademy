namespace _02.CompareАrrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a program that reads two integer arrays of size N from the console and compares them element by element.
    /// </summary>
    public class CompareАrrays
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            var firstArray = new int[size];
            var secondArray = new int[size];

            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;
            for (int i = 0; i < size; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }

            Console.WriteLine(areEqual? "Equal" : "Not equal");
        }
    }
}
