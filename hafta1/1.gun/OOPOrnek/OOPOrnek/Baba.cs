using OOPOrnek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Baba : Insan,IDinleveYaz
    {
        public void Dinle(string adi)
        {
            Console.WriteLine(adi + " dinliyor..");
        }

      

        public void Yaz(string adi)
        {
            Console.WriteLine(adi + " okuyor..");
        }
    }
}
