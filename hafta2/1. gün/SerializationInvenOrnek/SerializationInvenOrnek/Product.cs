using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationInvenOrnek
{
    [Serializable]
    public class Product
    {

        public string Name { get; set; }    
        public DateTime ExpireDate { get; set; }
        public double fiyat { get; set; }       

    }
}
