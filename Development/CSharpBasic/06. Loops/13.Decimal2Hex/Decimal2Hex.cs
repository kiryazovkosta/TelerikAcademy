namespace _13.Decimal2Hex
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class Decimal2Hex
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            int grade = 16;
            string hexadecimalNumber = string.Empty;
            while (number > 0)
            {
                long remainder = number % grade;
                switch (remainder)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        hexadecimalNumber = remainder + hexadecimalNumber;
                        break;
                    case 10:
                        hexadecimalNumber = 'A' + hexadecimalNumber;
                        break;
                    case 11:
                        hexadecimalNumber = 'B' + hexadecimalNumber;
                        break;
                    case 12:
                        hexadecimalNumber = 'C' + hexadecimalNumber;
                        break;
                    case 13:
                        hexadecimalNumber = 'D' + hexadecimalNumber;
                        break;
                    case 14:
                        hexadecimalNumber = 'E' + hexadecimalNumber;
                        break;
                    case 15:
                        hexadecimalNumber = 'F' + hexadecimalNumber;
                        break;
                    default:
                        break;
                }

                number = number / grade;
            }

            Console.WriteLine(hexadecimalNumber);
        }
    }
}
