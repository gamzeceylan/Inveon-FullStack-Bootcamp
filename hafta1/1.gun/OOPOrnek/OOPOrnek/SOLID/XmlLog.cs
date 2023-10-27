using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class XmlLog : ILog
    {
        public void Log(string value)
        {
            Console.WriteLine(value + " xml e kaydedildi");
        }
 
    }
}
