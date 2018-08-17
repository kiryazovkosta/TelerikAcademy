namespace _01.SchoolClasses.Contacts
{
    using System;
    public class Person
    {
        private readonly string name;

        public Person(string nameParam)
        {
            if (string.IsNullOrEmpty(nameParam))
            {
                throw new ArgumentNullException(nameof(this.name));
            }

            if (nameParam.Length < 3)
            {
                throw new ArgumentException(nameof(this.name));
            }

            this.name = nameParam;
        }

        public string Name
        {
            get => this.name;
        }
    }
}
