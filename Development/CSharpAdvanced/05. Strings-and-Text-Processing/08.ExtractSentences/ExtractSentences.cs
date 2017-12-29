namespace _08.ExtractSentences
{
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Write a program that extracts from a given text all sentences containing given word.
    /// </summary>
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            var sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] separators = text.Where(c => !char.IsLetter(c)).Distinct().ToArray();

            foreach (var sentence in sentences)
            {
                var words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (word.Trim() == pattern)
                    {
                        result.Append(string.Format("{0}. ", sentence.Trim()));
                        break;
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
