using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Cocuk : Insan
    {
        public string sifat;

        public void AdSoyadSifatYaz(string isim,string soyisim, string sifat)
        {
            Console.WriteLine(isim + " "+soyisim+" " +sifat);   
            // this ile de parametre almadan yazdırabilirdin. (this.isim)
        }
    }
}
