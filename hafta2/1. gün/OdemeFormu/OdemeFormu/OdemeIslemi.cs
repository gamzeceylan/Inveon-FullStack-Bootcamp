using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeIslemi
    {
        IOdemeTipi odeme;

        public OdemeIslemi(IOdemeTipi odeme)
        {
            this.odeme = odeme;
        }

        public string Ode(double tutar)
        {
            return odeme.OdemeYap(tutar);
        }
    }
}
