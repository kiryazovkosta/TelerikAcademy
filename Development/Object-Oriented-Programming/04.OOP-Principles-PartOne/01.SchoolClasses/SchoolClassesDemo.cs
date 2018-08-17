namespace _01.SchoolClasses
{
    using _01.SchoolClasses.Contacts;
    using System;
    using System.Collections.Generic;

    public class SchoolClassesDemo
    {
        public static void Main()
        {
            IClass cls = new Class();
            cls.AddStudent(new Student(1, "test01"));
            cls.AddStudent(new Student(2, "test02"));
            cls.AddStudent(new Student(3, "test03"));
            cls.AddStudent(new Student(4, "test04"));
            Console.WriteLine("---------------------------------");
            foreach (var student in cls.Students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------------------");
            cls.Students.Add(new Student(5, "test05"));
            foreach (var student in cls.Students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------------------");
            cls.AddStudent(new Student(5, ""));
            foreach (var student in cls.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
