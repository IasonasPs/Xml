using System.Xml;

namespace XmlReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

           

            string filetext =  Find.FindFile(desktop,"test.txt");

            Console.WriteLine(filetext);



        }
    }
}