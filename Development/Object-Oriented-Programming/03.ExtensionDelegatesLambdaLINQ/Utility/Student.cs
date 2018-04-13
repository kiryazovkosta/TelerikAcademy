namespace Utility
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private static List<Student> students = new List<Student>()
        {
            new Student("Ivan", "Popov", 16 , 201806010001, "02896512345", "ivan@yahoo.com", new List<int>(){ 2, 4, 5, 3, 2, 6, 3 }, new Group(1, "Mathematics")),
            new Student("Kiril", "Angelov", 22, FaculteteNumber = 201801010002, Email="kiril@abv.bg", Telephone="+359296512345", GroupNumber = new Group(1, "Mathematics"), Marks = new List<int>(){ 4, 2, 5, 3, 4, 6, 3 } },
            new Student("Bilqn", "Nenchev", 27, FaculteteNumber = 201806010003, Email="ivan@mail.bg", Telephone="05696512345", GroupNumber = new Group(1, "Mathematics"), Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student("Dimitar", "Donkov", 14, FaculteteNumber = 201801010004, Email="ivan@mail.bg", Telephone="05296512345", GroupNumber = new Group(2, "Phisics"), Marks = new List<int>(){ 6, 6, 5, 6, 6, 6, 6 } },
            new Student("Asen", "Kolchev", 32, FaculteteNumber = 201801010005, Email="ivan@yahoo.com", Telephone="+35996512345", GroupNumber = new Group(2, "Phisics"), Marks = new List<int>(){ 4, 4, 2, 3, 4, 4, 3 } },
            new Student("Deyan", "Zhelev", 11, FaculteteNumber = 201801010006, Email="ivan@post.bg", Telephone="026512345", GroupNumber = new Group(2, "Phisics"), Marks = new List<int>(){ 4, 4, 5, 3, 4, 5, 3 } },
            new Student("Todor", "Milchev", 5, FaculteteNumber = 201801010007, Email="todor@abv.bg", Telephone="+359512345", GroupNumber = new Group(2, "Phisics"), Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student("Vasil", "Borisov", 24, FaculteteNumber = 201801010008, Email="ivan@yahoo.com", Telephone="03496512345", GroupNumber = new Group(3, "Art"), Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student("Trayan", "Jelev", 13, FaculteteNumber = 201806010009, Email="ivan@yahoo.com", Telephone="0551196512345", GroupNumber = new Group(3, "Art"), Marks = new List<int>(){ 4, 4, 5, 3, 4, 5, 3 } },
            new Student("Krasimir", "Lechev", 17, FaculteteNumber = 201801010010, Email="ivan@yahoo.com", Telephone="044321112", GroupNumber = new Group(3, "Art"), Marks = new List<int>(){ 4, 4, 5, 3, 4, 6, 3 } },
            new Student("Lazar", "Uzunov", 29, FaculteteNumber = 201801010011, Email="lazar@abv.bg", Telephone="+3596512345", GroupNumber = new Group(3, "Art"), Marks = new List<int>(){ 4, 2, 5, 3, 4, 3, 2 } },
            new Student("Georgi", "Georgiev", 18, FaculteteNumber = 201801010012, Email="ivan@google.com", Telephone="0896512345", GroupNumber = new Group(4, "Sport"), Marks = new List<int>(){ 2, 2, 2, 2, 2, 2, 2 } },
            new Student("Krasimir", "Ivanov", 13, FaculteteNumber = 201806010013, Email="ivan@google.com.com", Telephone="+35923446", GroupNumber = new Group(4, "Sport"), Marks = new List<int>(){ 6, 6, 6, 6, 6, 6, 6 } },
        };

        private string firstName;
        private string lastName;
        private int age;
        private long faculteteNumber;
        private string telephone;
        private string email;
        private List<int> marks = new List<int>();
        private Group groupNumber;

        public Student(string firstName, string lastName, int age, long faculteteNumber, string telephone, string email, List<int> marks, Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FaculteteNumber = faculteteNumber;
            this.Telephone = telephone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
    }

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

        public Group GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value ?? throw new ArgumentException(nameof(this.groupNumber));
            }
        }

        public static List<Student> Students
        {
            get
            {
                return Students1;
            }
        }

        public static List<Student> Students1 { get => Students2; set => Students2 = value; }
        public static List<Student> Students2 { get => students; set => students = value; }

        public string StudentYearByFacultetNumber()
        {
            return this.FaculteteNumber.ToString().Substring(4, 2);
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Age} {this.GroupNumber} {this.Email} {this.Telephone}";
        }
    }
}
