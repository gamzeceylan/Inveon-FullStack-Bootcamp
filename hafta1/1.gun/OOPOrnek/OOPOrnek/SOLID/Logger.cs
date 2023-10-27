using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class Logger
    {
        public ILog ilog;

        // ILog classını kalıtım alan hangi türde nesne gelirde gelsin kabul et demek
        // derste ilk switch case ile yapılmıştı ve yeni nesne eklendiğinde sürekli kodun değiştirilmesi problemi vardı. 
        public Logger(ILog ilog)
        {
            this.ilog = ilog;
        }   
          
        public void LogYaz(string value)
        {
            ilog.Log(value);
        }
    }
}
