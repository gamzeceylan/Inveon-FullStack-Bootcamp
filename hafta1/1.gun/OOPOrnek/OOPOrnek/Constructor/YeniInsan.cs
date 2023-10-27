using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.Constructor
{
    public class YeniInsan
    {

        public Kafa kafa;
        public string ad;
        public string soyad;


        public YeniInsan(Kafa kafa, string ad, string soyad)
        {
            this.kafa = kafa;
            this.ad = ad;
            this.soyad = soyad;
        }  
        
        public void EkranaYaz()
        {
            Console.WriteLine("kişinin adı :" + ad + " soyad : " + soyad + " göz rengi " + kafa.goz.renk + " burnu : " + kafa.burun.tipi + " kulağı : " + kafa.kulak.sekil);
        }
    }
}
