using System;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
                    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public enum Type
        {
            Class,
            Struct,
            Iterface,
            Enum,
            Method
        }

        public VersionAttribute(Type component, string name, string version)
        {
            Component = component;
            Name = name;
            Version = version;
        }

        public string Version { get; set; }
        public Type Component { get; set; }
        public string Name { get; set; }
    }
}