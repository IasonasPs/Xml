using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace XmlReader
{
    public class Find
    {
        public static string FindFile(string path,string name)
        {
            try
            {
                var p = path+@"\"+name;
                string text = File.ReadAllText(p );
                return text;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
