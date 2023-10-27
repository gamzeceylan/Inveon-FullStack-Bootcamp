using OOPOrnek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class UsluCocuk : Cocuk, IAskereGit, IEhliyetAl
    {
        public void AskereGit(string adi)
        {
            Console.WriteLine(adi + " askere gidiyor");
        }

        public void EhliyetAl(string adi)
        {
            Console.WriteLine(adi + " ehliyet alıyor");
        }
    }
}
