namespace _03.CheckForaPlayCard
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Classical play cards use the following signs to designate the card face:  2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A . 
    /// Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign 
    /// or "no CONTENT_OF_STRING" otherwise.
    /// </summary>
    public class CheckForAPlayCard
    {
        public static void Main()
        {
            List<string> cardFaces = new List<string>()
            {
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "J",
                "Q",
                "K",
                "A"
            };

            string enteredCard = Console.ReadLine();
            if (cardFaces.Contains(enteredCard))
            {
                string output = string.Format("yes {0}", enteredCard);
                Console.WriteLine(output);
            }
            else
            {
                string output = string.Format("no {0}", enteredCard);
                Console.WriteLine(output);
            }
        }
    }
}
