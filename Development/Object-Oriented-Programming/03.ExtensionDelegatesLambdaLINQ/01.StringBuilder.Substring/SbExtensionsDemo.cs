namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SbExtensionsDemo
    {
        public static void Main()
        {
            var text = new StringBuilder("Zorba The Greek");
            Console.WriteLine(text.Substring(0, 5));
            Console.WriteLine(text.Substring(6, 3));
            Console.WriteLine(text.Substring(10, 5));
        }
    }
}
