using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationInvenOrnek
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }    
        public string Phone { get; set; }   
        public DateTime DoB { get; set; }
        public string Deparment { get; set; }
        public int Salary { get; set; }

        [NonSerialized] // bu değişken serialization a uğramasın
        public string addionalInfo;

      
    }
}
