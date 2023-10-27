using OOPOrnek;
using OOPOrnek.Abstracts;
using OOPOrnek.Constructor;
using OOPOrnek.Overrides;
using OOPOrnek.Reflection;
using OOPOrnek.SOLID;
using System.Reflection;

Insan.boy = 180;
//ClassIsmi nesnemizinAdi = new ClassIsmi();
Insan i = new Insan();
i.ad = "ibrahim";
i.soyad = "Gökyar";
i.Uyu("Hakan","Yılmaz");

Insan i2 = new Insan("metin", "yılmaz");

Insan i3 = new Insan("Hüseyin", "yılmaz", 33, 3.14, true);


Araba a = new Araba();
a.marka = "bmw";
a.model = "x5";
a.Git(a.marka,a.model);


Anne an = new Anne();
an.ad = "fahriye";
an.soyad = "Gökyar";
an.Uyu(an.ad, an.soyad);
an.EkranaYaz(an.ad, an.soyad);
an.Oku(an.ad);
an.Dinle(an.ad);
an.Yaz(an.ad);



Baba b = new Baba();
b.ad = "Kasım";
b.soyad = "Gökyar";
b.EkranaYaz(b.ad, b.soyad);
b.Dinle(b.ad);
b.Yaz(b.ad);



Cocuk c = new Cocuk();
c.ad = "ibrahim";
c.soyad = "Gökyar";
c.EkranaYaz(c.ad, c.soyad);

AkilliCocuk ak = new AkilliCocuk();
ak.ad = "Hakan";
ak.soyad = "Yılmaz";
ak.sifat = "Akıllıdır";
ak.AdSoyadSifatYaz(ak.ad, ak.soyad, ak.sifat);
ak.AskereGit(ak.ad);
ak.EhliyetAl(ak.ad);
ak.KlubeGit(ak.ad);


UsluCocuk us = new UsluCocuk();
us.ad = "Mehmet";
us.soyad = "Yılmaz";
us.sifat = "Usludur";
us.AdSoyadSifatYaz(us.ad, us.soyad, us.sifat);
us.AskereGit(us.ad);
us.EhliyetAl(us.ad);

HiperAktifCocuk hp = new HiperAktifCocuk();
hp.ad = "Hüseyin";
hp.EhliyetAl(hp.ad);


//Calisan cal = new Calisan();

GenelMudur gm = new GenelMudur();
Mudur m = new Mudur();
Programci p = new Programci();
Stajyer s = new Stajyer();


double toplamMaas = 0;

toplamMaas += gm.MaasinizNedir();
toplamMaas += m.MaasinizNedir();
toplamMaas += p.MaasinizNedir();
toplamMaas += s.MaasinizNedir();
Console.WriteLine("Toplam Maaş : " + toplamMaas + " Tl dir.");

Console.WriteLine();
Matematik me = new Matematik();
//me.Topla()


Goz goz = new Goz("yeşil", "abc");
Kulak kulak = new Kulak("kepçe");
Burun burun = new Burun("kemer");
Kafa kafa = new Kafa(goz,burun,kulak);
goz.renk = "Siyah";
YeniInsan yeni = new YeniInsan(kafa, "metin", "yılmaz");
yeni.EkranaYaz();


DbLog dbLog = new DbLog();
XmlLog xmlLog = new XmlLog();
Logger logger = new Logger(xmlLog);
logger.LogYaz("303 nolu hata kodu oluştu");

Child ch = new Child();
ch.Yaz();


// Reflection
Console.WriteLine("\n\n");
Type t = typeof(MyClass); // runtime da nesne oluşturduk
MethodInfo[] mi = t.GetMethods(); // sınıfın parametrelerine, metodlarına erişebildik
foreach (MethodInfo info in mi)
{
    ParameterInfo[] pi = info.GetParameters();
    Console.WriteLine("Method adı: " + info.Name+ "Dönüş Tipi: "+  info.ReturnType);
    if(pi.Length > 0)
    {
        Console.WriteLine("parametre var");
    }
    for (int iX = 0; iX < pi.Length; iX++)
    {
        Console.WriteLine(iX + 1 + ".parametre: Dönüş değeri: "+ pi[iX].ParameterType.Name + " Adı: " + pi[iX].Name);
    }
}

MyClass my= new MyClass();
my.GetType().GetMethods().ToList().ForEach(method =>
{

});