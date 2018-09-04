// 	<copyright file=StudentsAndWorkersDemo.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 9:47:04 AM</date>
// 	<summary>Class representing a StudentsAndWorkersDemo entity</summary>
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class StudentsAndWorkersDemo
    {
        public static void Main(string[] args)
        {
            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var students = new List<Student>();
            int i = 0;
            for (; i < 10; i++)
            {
                students.Add(new Student()
                {
                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}",
                    Grade = i
                });
            }

            var sortedStudents = students.OrderByDescending(s => s.Grade);

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            var workers = new List<Worker>();
            for (; i < 20; i++)
            {
                workers.Add(new Worker()
                {
                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}",
                    WeekSalary = i + 20 + 100,
                    WorkHoursPerDay = 8
                });
            }

            var sortedWokers = workers.OrderByDescending(x => x.MoneyPerHour());

            // Merge the lists and sort them by first name and last name.
            var humans = new List<Human>();
            foreach (Worker worker in workers)
            {
                humans.Add(worker);
            }
            foreach (Student student in students)
            {
                humans.Add(student);
            }

            var orderedHuman = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
        }
    }
}