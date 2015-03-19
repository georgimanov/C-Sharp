namespace VersionAttribute
{
    using System;
    using System.Reflection;

    [Version(VersionAttribute.Type.Class, "VersionAttributeTest", "2.11")]
    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            var attributes = typeof(VersionAttributeTest).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in attributes)
            {
                Console.WriteLine("{0}: {1}; Version: {2}", attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}