using System;
using System.Attribute;
[AttributeUsage(AttributeTargets.All)]
public class VersionAttribute : System.Attribute
{
    public readonly string Version;

    public VersionAttribute(string version)
    {
        this.Version = version;
    }

}