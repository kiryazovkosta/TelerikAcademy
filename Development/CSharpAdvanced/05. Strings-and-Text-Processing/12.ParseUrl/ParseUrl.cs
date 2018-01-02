namespace _12.ParseUrl
{
    using System;

    /// <summary>
    /// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
    /// and extracts from it the [protocol], [server] and [resource] elements.
    /// </summary>
    public class ParseUrl
    {
        public static void Main()
        {
            var url = Console.ReadLine();
            int protocolIndex = url.IndexOf("://");
            //Console.WriteLine(protocolIndex);
            Console.WriteLine(string.Format("[protocol] = {0}", url.Substring(0, protocolIndex)));
            int serverIndex = url.IndexOf("/", protocolIndex + 3);
            //Console.WriteLine(serverIndex);
            Console.WriteLine(string.Format("[server] = {0}", url.Substring(protocolIndex + 3, serverIndex - (protocolIndex + 3))));
            Console.WriteLine(string.Format("[resource] = {0}", url.Substring(serverIndex, url.Length - serverIndex)));
        }
    }
}
