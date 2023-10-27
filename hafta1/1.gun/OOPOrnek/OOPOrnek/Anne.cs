using OOPOrnek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    //anne class ı Insan class ından türemiştir.

    public class Anne : Insan, IOku, IDinleveYaz
    {
        public void Dinle(string adi)
        {
            Console.WriteLine(adi + " dinliyor..");
        }

        public void Oku(string adi)
        {
            Console.WriteLine(adi + " okuyor..");
        }

        public void Yaz(string adi)
        {
            Console.WriteLine(adi + " yazıyor..");
        }
    }
}
