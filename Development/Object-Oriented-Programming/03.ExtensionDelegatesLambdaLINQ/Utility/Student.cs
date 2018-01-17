namespace Utility
{
    using System.Collections.Generic;

    public class Student
    {
        private static List<Student> students = new List<Student>()
        {
            new Student { FirstName = "Ivan", LastName = "Popov", Age = 16 },
            new Student { FirstName = "Kiril", LastName = "Angelov", Age = 22},
            new Student { FirstName = "Bilqn", LastName = "Nenchev", Age = 27},
            new Student { FirstName = "Dimitar", LastName = "Donkov", Age = 14},
            new Student { FirstName = "Asen", LastName = "Kolchev", Age = 32},
            new Student { FirstName = "Deyan", LastName = "Zhelev", Age = 11},
            new Student { FirstName = "Todor", LastName = "Milchev", Age = 5},
            new Student { FirstName = "Vasil", LastName = "Borisov", Age = 24},
            new Student { FirstName = "Trayan", LastName = "Jelev", Age = 13},
            new Student { FirstName = "Krasimir", LastName = "Lechev", Age = 17},
            new Student { FirstName = "Lazar", LastName = "Uzunov", Age = 29},
            new Student { FirstName = "Georgi", LastName = "Georgiev", Age = 18},
            new Student { FirstName = "Krasimir", LastName = "Ivanov", Age = 13},
        };

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Age}";
        }
    }
}
