using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Ozellikler
    {

        public string ad = null;
        public string soyad;
        public int yas; //0;
        public double maas; //3.14
        public bool cinsiyet;  //true yada false 
        public void Oku(string adi)
        {
            Console.WriteLine(adi + " okuyor");
        }
        public void Dinle(string adi)
        {
            Console.WriteLine(adi + " dinliyor");
        }
        public void Yaz(string adi)
        {
            Console.WriteLine(adi + " yazıyor");
        }

        public void Uyu(string isim, string soyisim)
        {
            Console.WriteLine(isim + " " + soyisim + " Uyuyor");
        }

        public void EkranaYaz(string isim, string soyisim)
        {
            Console.WriteLine("Kişinin adı : " + isim + " kişinin soyadı: " + soyisim);
        }

    }
}
