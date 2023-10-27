using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.Reflection
{
    public class MyClass
    {
        public int x;
        public int y;

        private void MesajGoster()
        {
            Console.WriteLine("x in değeri: " + x + " y nin değeri: " + y); ;
        }
        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public MyClass()
        {
                
        }
        public bool IsBetween(int i)
        {
            if (i > 0) return true;
            return false;
        }
        public double CostSalary(int hour, double Salary) => hour * Salary;
    }
}
