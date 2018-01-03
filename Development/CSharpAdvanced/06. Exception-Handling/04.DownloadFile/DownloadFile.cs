namespace _04.DownloadFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory. 
    /// Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.
    /// </summary>
    class DownloadFile
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(@"https://www.telerik.com/sfimages/default-source/blogs/super_ninja-png", "super_ninja.png");
                }
                catch (ArgumentNullException anException)
                {
                    Console.WriteLine(anException.Message);
                }
                catch (WebException wException)
                {
                    Console.WriteLine(wException.Message);
                }
            }
        }
    }
}
