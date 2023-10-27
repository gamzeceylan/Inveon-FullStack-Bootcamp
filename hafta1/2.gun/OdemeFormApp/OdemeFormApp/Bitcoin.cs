using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class Bitcoin : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return "Bitcoin  ile " + tutar + " TL  ödeme yapıldı.";
        }
    }
}
