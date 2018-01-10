namespace _11.VersionAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
    /// and holds a version in the format major.minor (e.g. 2.11).
    /// Apply the version attribute to a sample class and display its version at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | 
        AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string versionParam)
        {
            this.Version = versionParam;
        }

        public string Version { get; private set; }
    }
}
