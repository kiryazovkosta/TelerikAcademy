namespace _07.EncodeAndDecode
{
    using System;
    using System.Text;

    /// <summary>
    /// Write a program that encodes and decodes a string using given encryption key (cipher).
    /// The key consists of a sequence of characters.
    /// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.
    /// When the last key character is reached, the next is the first.
    /// </summary>
    public class EncodeAndDecode
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var key = Console.ReadLine();

            var cryptedText = Encrypt(text, key);
            Console.WriteLine(cryptedText);

            var decryptedText = Decrypt(cryptedText, key);
            Console.WriteLine(decryptedText);
        }

        public static string Encrypt(string text, string key)
        {
            int currentKeyIndex = 0;

            var symbols = text.ToCharArray();
            var cryptedText = new char[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                if (currentKeyIndex >= key.Length)
                {
                    currentKeyIndex = 0;
                }

                int k = Convert.ToInt32(key[currentKeyIndex]);
                cryptedText[i] = (char)(symbols[i] ^ k);
                currentKeyIndex++;
            }

            return new string(cryptedText);
        }

        public static string Decrypt(string text, string key)
        {
            int currentKeyIndex = 0;
            var cryptedText = text.ToCharArray();

            var decryptedText = new char[cryptedText.Length];
            for (int i = 0; i < cryptedText.Length; i++)
            {
                if (currentKeyIndex >= key.Length)
                {
                    currentKeyIndex = 0;
                }

                int k = Convert.ToInt32(key[currentKeyIndex]);
                decryptedText[i] = (char)(cryptedText[i] ^ k);
                currentKeyIndex++;
            }

            return new string(decryptedText);
        }
    }
}
