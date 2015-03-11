using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;

namespace JSONtoXML
{
    class Program
    {
        static void Main()
        {
            var jsonPath = @"../../JSON.txt";

            StringBuilder sb = new StringBuilder();
            using (var sr = new StreamReader(jsonPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }

            const string json = @"{
    ""foo"":""bar"",
    ""complexFoo"": {
        ""subFoo"":""subBar""
    }
}";
            byte[] bytes = Encoding.ASCII.GetBytes(sb.ToString());
            using (var stream = new MemoryStream(bytes))
            {
                var quotas = new XmlDictionaryReaderQuotas();
                var jsonReader = JsonReaderWriterFactory.CreateJsonReader(stream, quotas);
                var xml = XDocument.Load(jsonReader);
                Console.WriteLine(xml);
            }
 


        }
    }
}
