namespace _11.VersionAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
    /// and holds a version in the format major.minor (e.g. 2.11).
    /// Apply the version attribute to a sample class and display its version at runtime.
    /// </summary>
    [Version("1.3")]
    public class AttributeDemo
    {
        [Version("0.0.2")]
        public static void Main()
        {
            Type type = typeof(AttributeDemo);
            object[] classAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in classAttributes)
            {
                Console.WriteLine("This class version is {0}. ", attr.Version);
            }
            
            object[] methodAttributes = type.GetMethod("Main").GetCustomAttributes(false);
            foreach (VersionAttribute attr in methodAttributes)
            {
                Console.WriteLine("This method version is {0}. ", attr.Version);
            }

            Type testType = typeof(AttributeDemo);
            MethodInfo toInvoke = testType.GetMethod("Print");
            toInvoke.Invoke(null, new object[] { "Kosta" });

            var methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.Name} -> {method.IsVirtual}");
            }
        }

        public static void Print(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
