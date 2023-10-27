using OOPOrnek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class HiperAktifCocuk : Cocuk, IEhliyetAl
    {
        public void EhliyetAl(string adi)
        {
            Console.WriteLine(adi + " ehliyet alıyor");
        }
    }
}
