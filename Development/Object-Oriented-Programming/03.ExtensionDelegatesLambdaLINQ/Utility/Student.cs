namespace Utility
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private static List<Student> students = new List<Student>()
        {
            new Student { FirstName = "Ivan", LastName = "Popov", Age = 16 , FaculteteNumber = 201801010001, Email="ivan@yahoo.com", Telephone="02896512345", GroupNumber = 1, Marks = new List<int>(){ 2, 4, 5, 3, 2, 6, 3 } },
            new Student { FirstName = "Kiril", LastName = "Angelov", Age = 22, FaculteteNumber = 201801010002, Email="kiril@abv.bg", Telephone="+359296512345", GroupNumber = 1, Marks = new List<int>(){ 4, 2, 5, 3, 4, 6, 3 } },
            new Student { FirstName = "Bilqn", LastName = "Nenchev", Age = 27, FaculteteNumber = 201801010003, Email="ivan@mail.bg", Telephone="05696512345", GroupNumber = 1, Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student { FirstName = "Dimitar", LastName = "Donkov", Age = 14, FaculteteNumber = 201801010004, Email="ivan@mail.bg", Telephone="05296512345", GroupNumber = 2, Marks = new List<int>(){ 6, 6, 5, 6, 6, 6, 6 } },
            new Student { FirstName = "Asen", LastName = "Kolchev", Age = 32, FaculteteNumber = 201801010005, Email="ivan@yahoo.com", Telephone="+35996512345", GroupNumber = 2, Marks = new List<int>(){ 4, 4, 2, 3, 4, 4, 3 } },
            new Student { FirstName = "Deyan", LastName = "Zhelev", Age = 11, FaculteteNumber = 201801010006, Email="ivan@post.bg", Telephone="026512345", GroupNumber = 2, Marks = new List<int>(){ 4, 4, 5, 3, 4, 5, 3 } },
            new Student { FirstName = "Todor", LastName = "Milchev", Age = 5, FaculteteNumber = 201801010007, Email="todor@abv.bg", Telephone="+359512345", GroupNumber = 2, Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student { FirstName = "Vasil", LastName = "Borisov", Age = 24, FaculteteNumber = 201801010008, Email="ivan@yahoo.com", Telephone="03496512345", GroupNumber = 3, Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student { FirstName = "Trayan", LastName = "Jelev", Age = 13, FaculteteNumber = 201801010009, Email="ivan@yahoo.com", Telephone="0551196512345", GroupNumber = 3, Marks = new List<int>(){ 4, 4, 5, 3, 4, 5, 3 } },
            new Student { FirstName = "Krasimir", LastName = "Lechev", Age = 17, FaculteteNumber = 201801010010, Email="ivan@yahoo.com", Telephone="044321112", GroupNumber = 3, Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student { FirstName = "Lazar", LastName = "Uzunov", Age = 29, FaculteteNumber = 201801010011, Email="lazar@abv.bg", Telephone="+3596512345", GroupNumber = 3, Marks = new List<int>(){ 4, 2, 5, 3, 4, 3, 2 } },
            new Student { FirstName = "Georgi", LastName = "Georgiev", Age = 18, FaculteteNumber = 201801010012, Email="ivan@google.com", Telephone="0896512345", GroupNumber = 4, Marks = new List<int>(){ 2, 2, 2, 2, 2, 2, 2 } },
            new Student { FirstName = "Krasimir", LastName = "Ivanov", Age = 13, FaculteteNumber = 201801010013, Email="ivan@google.com.com", Telephone="+35923446", GroupNumber = 4, Marks = new List<int>(){ 6, 6, 6, 6, 6, 6, 6 } },
        };

        private string firstName;
        private string lastName;
        private int age;
        private long faculteteNumber;
        private string telephone;
        private string email;
        private List<int> marks = new List<int>();
        private int groupNumber;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException(nameof(this.firstName));
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException(nameof(this.lastName));
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(this.age));
                }

                this.age = value;
            }
        }

        public long FaculteteNumber
        {
            get
            {
                return this.faculteteNumber;
            }
            set
            {
                this.faculteteNumber = value;
            }
        }

        public string Telephone
        {
            get
            {
                return this.telephone;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.telephone));
                }
                if (!value.StartsWith("+359") && !value.StartsWith("0"))
                {
                    throw new ArgumentException(nameof(this.telephone));
                }

                this.telephone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.email));
                }

                if (!value.Contains(".") || !value.Contains("@"))
                {
                    throw new ArgumentException(nameof(this.email));
                }

                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                foreach (var item in value)
                {
                    if (item <= 1 || item >= 7)
                    {
                        throw new ArgumentException(nameof(this.marks));
                    }
                }

                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(this.groupNumber));
                }

                this.groupNumber = value;
            }
        }

        public static List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Age} {this.GroupNumber} {this.Email} {this.Telephone}";
        }
    }
}
