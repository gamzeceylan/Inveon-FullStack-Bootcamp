using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Insan
    {

        //global değişken
        //acccess modifiers datatype değişkenAdi 
        public string ad = null;
        public string soyad;
        public int yas; //0;
        public double maas; //3.14
        public bool cinsiyet;  //true yada false 
        public static int boy;
        //metotlar 2 ye ayrılırlar 
        //geriye değer döndüren ve geriye değer döndürmeyen şeklinde
        //access modifiers dönüşTipi metodAdi()  {  }
        public  void Uyu(string isim,string soyisim)
        {
         
            int a = 5;
            Console.WriteLine(isim +" "+ soyisim + " Uyuyor");
        }

        public void EkranaYaz(string isim, string soyisim)
        {
           
            ad = "Hakan";
            Console.WriteLine("Kişinin adı : " + isim + " kişinin soyadı: "+soyisim);
        }


        //boş constructor 
        public Insan()
        {

        }

        //parametre alan constructor
        public Insan(string ad,string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public Insan(string ad,string soyad,int yas,double maas, bool cinsiyet)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.yas = yas;
            this.maas = maas;
            this.cinsiyet = cinsiyet;
        }
    }
}
