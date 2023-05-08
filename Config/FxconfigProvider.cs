using System.Xml;
using Microsoft.Extensions.Configuration;

namespace Config
{
    public class FxconfigProvider:FileConfigurationProvider
    {
        public FxconfigProvider(FileConfigurationSource source) : base(source)
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
                var connectionString = xml.Attributes["connectionStrings"].Value;

                data[$"{name}.connectionString"] = connectionString;

                var xmlAttribute = xml.Attributes["providerName"];
                if (xmlAttribute != null)
                {
                    data[$"{name}.providerName]"]= xmlAttribute.Value;
                }
            }

            var nodeList = doc.SelectNodes("configuration/appSettings/add");
            foreach (var xmlNode in nodeList.Cast<XmlNode>())
            {
                var value = xmlNode.Attributes["key"].Value;
                value = value.Replace(",", ":");
                var s = xmlNode.Attributes["value"].Value;
                data[value] = s;
            }
        }
    }
}