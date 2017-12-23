namespace _03.CompareCharArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompareCharArrays
    {
        private static readonly int zero = 0;
        private static readonly int firstArrayIndex = 1;
        private static readonly int secondArrayIndex = 2;

        public static void Main()
        {
            char[] firstArray = Console.ReadLine().ToCharArray();
            char[] secondArray = Console.ReadLine().ToCharArray();

            int smallerLength = zero;
            int biggerLength = zero;
            int biigerArrayIndex = zero;

            if (firstArray.GetLength(dimension: zero)> secondArray.GetLength(dimension: zero))
            {
                smallerLength = secondArray.GetLength(dimension: zero);
                biggerLength = firstArray.GetLength(dimension: zero);
                biigerArrayIndex = firstArrayIndex;
            }
            else
            {
                smallerLength = firstArray.GetLength(dimension: zero);
                biggerLength = secondArray.GetLength(dimension: zero);
                biigerArrayIndex = secondArrayIndex;
            }

            char result = '=';
            int index = zero;
            for (; index < smallerLength; index++)
            {
                if (firstArray[index] > secondArray[index])
                {
                    result = '>';
                }
                else if (firstArray[index] < secondArray[index])
                {
                    result = '<';
                }
            }

            if (biggerLength > smallerLength)
            {
                if (biigerArrayIndex == firstArrayIndex)
                {
                    result = '>';
                }
                else
                {
                    result = '<';
                }  
            }

            Console.WriteLine(result);
        }
    }
}