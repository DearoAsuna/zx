using System.Xml;
using Microsoft.Extensions.Configuration;

namespace Json1
{
    public class FxconfigProvider:FileConfigurationProvider
    {
        public FxconfigProvider(FxConfigSourse source) : base(source)
        {

        }

        public override void Load(Stream stream)
        {
            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);
            var xmlNodeList = doc.SelectNodes("configuration/connectionStrings/add");
            foreach (XmlNode xml in xmlNodeList.Cast<XmlNode>())
            {
                var name = xml.Attributes["name"].Value;

                var connectionString = xml.Attributes["connectionString"];
                data[$"{name}:connectionString"] = connectionString.Value;

                var xmlAttribute = xml.Attributes["providerName"];
                if (xmlAttribute != null)
                {
                    data[$"{name}:providerName]"]= xmlAttribute.Value;
                }
            }

            var nodeList = doc.SelectNodes("configuration/appSettings/add");
            foreach (var xmlNode in nodeList.Cast<XmlNode>())
            {
                var value = xmlNode.Attributes["key"].Value;
                Console.WriteLine("name"+value);
                value = value.Replace(",", ":");
                var s = xmlNode.Attributes["value"].Value;
                Console.WriteLine("value" + s);
                data[value] = s;
            }

            Data = data;

        }
    }
}