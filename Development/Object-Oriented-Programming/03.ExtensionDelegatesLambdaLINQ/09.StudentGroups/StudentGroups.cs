namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Utility;

    public class StudentGroups
    {
        private const int GroupNumber = 2;

        private const string Email = "abv.bg";

        public static void Main()
        {
            // Create a List<Student> with sample students.
            var students = Student.Students;

            //  Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
            var selectedStudents = GetStudentsFromGroupLinq(students, GroupNumber);
            selectedStudents.Each(Console.WriteLine);
            Console.WriteLine();

            //  Select only the students that are from group number 2. Use extension methods. Order the students by FirstName.
            selectedStudents = GetStudentsFromGroupEM(students, GroupNumber);
            selectedStudents.Each(Console.WriteLine);
            Console.WriteLine();

            // Extract all students that have email in abv.bg. Use string methods and LINQ.
            selectedStudents = GetStudentsByEmail(students, Email);
            selectedStudents.Each(Console.WriteLine);
            Console.WriteLine();

            // Extract all students with phones in Sofia. Use LINQ.
            selectedStudents = ExtractStudentsByPhoneInSofia(students);
            selectedStudents.Each(Console.WriteLine);
            Console.WriteLine();

            // elect all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            var excelentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = $"{student.FirstName} {student.LastName}",
                    student.Marks
                };
            foreach (var item in excelentStudents)
            {
                Console.WriteLine($"{item.FullName} -> {string.Join(", ", item.Marks)}");
            }

            Console.WriteLine();

            // Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.
            var weakStudents = students
                .Where(x => x.Marks.FindAll(s => s == 2).Count() == 2)
                .Select(s => new
                {
                    FullName = $"{s.FirstName} {s.LastName}",
                    s.Marks
                });
            foreach (var item in weakStudents)
            {
                Console.WriteLine($"{item.FullName} -> {string.Join(", ", item.Marks)}");
            }

            Console.WriteLine();
        }

        public static IEnumerable<Student> GetStudentsFromGroupLinq(IEnumerable<Student> students, int groupNumber)
        {
            var orderedStudents =
                from student in students
                where student.GroupNumber == groupNumber
                orderby student.FirstName
                select student;
            return orderedStudents;
        }

        public static IEnumerable<Student> GetStudentsFromGroupEM(IEnumerable<Student> students, int groupNumber)
        {
            var orderedStudents = students
                .Where(x => x.GroupNumber == groupNumber)
                .OrderBy(x => x.FirstName)
                .ToList();
            return orderedStudents;
        }

        public static IEnumerable<Student> GetStudentsByEmail(IEnumerable<Student> students, string email)
        {
            var selectedStudents =
                from student in students
                where student.Email.ToLower().EndsWith(email.ToLower())
                select student;

            return selectedStudents;
        }

        public static IEnumerable<Student> ExtractStudentsByPhoneInSofia(IEnumerable<Student> students)
        {
            var selectedStudents =
                from student in students
                where student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("02")
                select student;

            return selectedStudents;
        }
    }
}
