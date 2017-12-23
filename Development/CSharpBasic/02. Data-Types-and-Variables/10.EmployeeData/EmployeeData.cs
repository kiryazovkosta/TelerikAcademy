namespace _10.EmployeeData
{
    using System;

    /// <summary>
    /// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    /// •First name
    /// •Last name
    /// •Age(0...100)
    /// •Gender(m or f)
    /// •Personal ID number(e.g. 8306112507)
    /// •Unique employee number(27560000…27569999)
    /// Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
    /// Use descriptive names.Print the data at the console.
    /// </summary>
    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = "Kosta";
            string lastName = "Kiryazov";
            byte age = 36;
            char gender = 'm';
            ulong id = 8306112507;
            uint uniqueNumber = 27569999;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(id);
            Console.WriteLine(uniqueNumber);
        }
    }
}
