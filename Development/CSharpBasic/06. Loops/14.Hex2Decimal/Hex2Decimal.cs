namespace _14.Hex2Decimal
{
    using System;

    /// <summary>
    /// Using loops write a program that converts a hexadecimal integer number to its decimal form.
    /// •The input is entered as string. The output should be a variable of type long.
    /// </summary>
    public class Hex2Decimal
    {
        public static void Main()
        {
            string hexNumber = Console.ReadLine();
            int power = 0;
            long number = 0;
            for (int index = hexNumber.Length - 1; index >=0 ; index--)
            {
                int currentNumber = 0;
                switch (hexNumber[index])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        currentNumber = int.Parse(hexNumber[index].ToString());
                        break;
                    case 'A':
                        currentNumber = 10;
                        break;
                    case 'B':
                        currentNumber = 11;
                        break;
                    case 'C':
                        currentNumber = 12;
                        break;
                    case 'D':
                        currentNumber = 13;
                        break;
                    case 'E':
                        currentNumber = 14;
                        break;
                    case 'F':
                        currentNumber = 15;
                        break;
                    default:
                        break;
                }

                number += (long)(currentNumber * Math.Pow(16, power));
                power++;
            }

            Console.WriteLine(number);
        }
    }
}