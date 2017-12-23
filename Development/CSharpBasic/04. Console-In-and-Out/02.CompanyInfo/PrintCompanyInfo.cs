namespace _02.CompanyInfo
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// A company has name, address, phone number, fax number, web site and manager. 
    /// The manager has first name, last name, age and a phone number.
    /// Write a program that reads the information about a company and its manager and prints it back on the console.
    /// </summary>
    public class PrintCompanyInfo
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string phone = Console.ReadLine();

            StringBuilder companyInfo = new StringBuilder();
            companyInfo.AppendLine(companyName);
            companyInfo.AppendLine(string.Format("Address: {0}", companyAddress));
            companyInfo.AppendLine(string.Format("Tel. {0}", phoneNumber));
            companyInfo.AppendLine(string.Format("Fax: {0}", string.IsNullOrEmpty(faxNumber) ? "(no fax)" : faxNumber));
            companyInfo.AppendLine(string.Format("Web site: {0}", webSite));
            companyInfo.Append(string.Format("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, phone));
            Console.WriteLine(companyInfo.ToString());

        }
    }
}
