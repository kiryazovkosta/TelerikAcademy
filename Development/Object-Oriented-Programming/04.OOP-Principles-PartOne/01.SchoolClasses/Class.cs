namespace _01.SchoolClasses
{
    using System.Collections.Generic;
    using _01.SchoolClasses.Contacts;
    using Newtonsoft.Json;

    public class Class : IClass
    {
        private ICollection<IStudent> students;

        public Class()
        {
            this.students = new HashSet<IStudent>();
        }

        public ICollection<IStudent> Students
        {
            get
            {
                var studentsList = new HashSet<IStudent>();
                foreach (var student in this.students)
                {
                    studentsList.Add(student);
                }

                return studentsList;
            }
        }

        public void AddStudent(IStudent student)
        {
            this.students.Add(student);
        }
    }
}
