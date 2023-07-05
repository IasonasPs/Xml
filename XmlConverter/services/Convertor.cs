using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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

            Console.WriteLine(json);

            Save.SaveToFile(json,"jtest",false);
            return json;
        }
    }
}
