using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace XmlConvertor.services
{
    public class Convertor
    {
        public static string XmlToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xml);

            string json = JsonConvert.SerializeObject(doc);
            return json;
        }
        private static readonly XDeclaration _defaultDeclaration = new("1.0", null, null);
        public static string JsonToXml(string text)
        {
            //Console.WriteLine("----------------------------------------------------------------");
            var doc = JsonConvert.DeserializeXNode(text)!;
            var declaration = doc.Declaration ?? _defaultDeclaration;

            string xml = $"{declaration}{Environment.NewLine}{doc}";

            return xml;
        }
    }
}
