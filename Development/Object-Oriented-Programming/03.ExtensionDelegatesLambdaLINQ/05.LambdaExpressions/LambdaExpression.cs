namespace _05.LambdaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utility;
    using Utility.Contracts;

    public class LambdaExpression
    {
        public static void Main(string[] args)
        {
            var ordererStudents = Order(Student.Students);
            ordererStudents.Each(Console.WriteLine);

            var numbers = new int[] { 6, 12, 21, 33, 85, 25, 44, 123, 42 + 42 };
            var dividedNumbers = DividedBySevenAndThree(numbers);
            dividedNumbers.Each(Console.WriteLine);
        }

        public static IEnumerable<IStudent> Order(IEnumerable<IStudent> students)
        {
            var ordererStudents = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName);
            return ordererStudents;
        }

        public static IEnumerable<int> DividedBySevenAndThree(IEnumerable<int> numbers)
        {
            var dividedNumbers = numbers.Where(n => n % 3 == 0 && n % 7 == 0);
            return dividedNumbers;
        }
    }
}
