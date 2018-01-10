namespace _05.GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    /// Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    /// Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
    /// clearing the list, finding element by its value and ToString().
    /// Check all input parameters to avoid accessing elements at invalid positions.
    /// </summary>
    public class GenericClassDemo
    {
        public static void Main(string[] args)
        {
            var list = new GenericList<int>(8);
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(i + 1);
            }

            list.InsertAt(0, 0);
            Console.WriteLine(list.ToString());

            list.RemoveAt(8);
            Console.WriteLine(list.ToString());

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
