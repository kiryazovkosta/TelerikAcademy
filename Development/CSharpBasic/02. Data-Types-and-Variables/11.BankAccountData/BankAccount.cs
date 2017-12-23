namespace _11.BankAccountData
{
    using System;

    /// <summary>
    /// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
    /// 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account 
    /// using the appropriate data types and descriptive names.
    /// </summary>
    public class BankAccount
    {
        public static void Main()
        {
            string firstName = "Kosta";
            string middleName = "Andreev";
            string lastName = "Kiryazov";
            decimal balance = 23140.53M;
            string bankName = "Unicredit Bulbank";
            string iban = "BG44500105175407324931";
            string[] creditCards = new string[]
            {
                "341226403296022",
                "5326423701596686",
                "n/a"
            };

            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(lastName);
            Console.WriteLine(balance);
            Console.WriteLine(bankName);
            Console.WriteLine(iban);
            Console.WriteLine(creditCards[0]);
            Console.WriteLine(creditCards[1]);
            Console.WriteLine(creditCards[2]);
        }
    }
}
