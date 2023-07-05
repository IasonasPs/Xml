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
            string name = "test.txt";

            string txt = Find.FindFile(desktop, name);
            
            var test = Convertor.XmlToJson(txt);

             

            


        }
    }
}