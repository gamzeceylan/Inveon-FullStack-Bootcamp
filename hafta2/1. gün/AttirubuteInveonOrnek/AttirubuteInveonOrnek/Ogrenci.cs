using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttirubuteInveonOrnek
{
   
    public class Ogrenci
    {
        [ZorunluAlan]
        public string adi;
        [ZorunluAlan]
        public string soyadi;
        [ZorunluAlan]
        public string Bolum;

    }
}
