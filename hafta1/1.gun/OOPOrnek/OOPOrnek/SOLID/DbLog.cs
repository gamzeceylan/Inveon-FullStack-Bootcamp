using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class DbLog : ILog
    {
        public void Log(string value)
        {
            Console.WriteLine(value + " db e kaydedildi");
        }
    }
}
