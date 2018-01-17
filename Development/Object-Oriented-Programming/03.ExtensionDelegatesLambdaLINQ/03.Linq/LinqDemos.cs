namespace _03.Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utility;

    public class LinqDemos
    {
        public static void Main()
        {
            Console.WriteLine("All students");
            var students = Student.Students;
            students.Each(Console.WriteLine);

            Console.WriteLine($"{Environment.NewLine}First before last");
            var firstBeforeLastStudents = GetStudentsWithFirstNameBeforeLastNameAlphabetically(students);
            firstBeforeLastStudents.Each(Console.WriteLine);

            Console.WriteLine($"{Environment.NewLine}Age range");
            var ageRangeStudents = GetStudentsInAgeRange(students);
            ageRangeStudents.Each(Console.WriteLine);

            Console.WriteLine($"{Environment.NewLine}Ordered students");
            var orderedStudents = OrderStudents(students);
            orderedStudents.Each(Console.WriteLine);

            Console.WriteLine($"{Environment.NewLine} Divided by 7 and 3");
            var numbers = new List<int>()
            {
                3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60
            };
            var dividedNumbers = GetDividedBySevenAndThree(numbers);
            dividedNumbers.Each(Console.WriteLine);
        }

        /// <summary>
        /// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static IEnumerable<Student> GetStudentsWithFirstNameBeforeLastNameAlphabetically(IEnumerable<Student> students)
        {
            var selectedStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return selectedStudents;
        }

        /// <summary>
        /// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static IEnumerable<Student> GetStudentsInAgeRange(IEnumerable<Student> students)
        {
            var selectedStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            return selectedStudents;
        }

        /// <summary>
        /// Sort the students by first name and last name in descending order.
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static IEnumerable<Student> OrderStudents(IEnumerable<Student> students)
        {
            var orderedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName 
                select student;

            return orderedStudents;
        }

        /// <summary>
        /// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static IEnumerable<int> GetDividedBySevenAndThree(IEnumerable<int> numbers)
        {
            var dividedNumbers =
                from number in numbers
                where number % 7 == 0 && number % 3 == 0
                select number;

            return dividedNumbers;
        }
    }
}
