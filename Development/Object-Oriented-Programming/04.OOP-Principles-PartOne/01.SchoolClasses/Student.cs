namespace _01.SchoolClasses
{
    using System;
    using _01.SchoolClasses.Contacts;

    public class Student : Person, IStudent
    {
        private readonly int id;

        public Student(int idParam, string nameParam)
            : base(nameParam)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idParam));
            }

            this.id = idParam;
        }

        public override string ToString()
        {
            return $"{this.id:N5}.{base.Name}";
        }
    }
}
