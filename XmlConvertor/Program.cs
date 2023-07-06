using System.Security.Cryptography.X509Certificates;
using XmlConvertor.services;
using XmlReader;


namespace XmlConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filename = "xml.txt";
            string  path = @"..\..\..\..\XmlReader\XmlFiles";
            var fullPath = Path.GetFullPath(path);


            string xml = Find.FindFile(path, filename);
            string result = Convertor.XmlToJson(xml);
            Save.SaveToFile(result, "jsonfromXml.txt", true);


            string json = Find.FindFile(desktop, "jsonfromXml.txt");
            result = Convertor.JsonToXml(json);
            Save.SaveToFile(result, "XmlFromJson.txt", true);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("All files saved successfully!!");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");

        }
    }
}