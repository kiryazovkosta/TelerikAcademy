using System.Collections.Generic;

namespace _01.SchoolClasses.Contacts
{
    public interface IClass
    {
        ICollection<IStudent> Students { get; }

        void AddStudent(IStudent student);
    }
}
