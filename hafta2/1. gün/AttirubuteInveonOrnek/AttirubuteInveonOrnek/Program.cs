// See https://aka.ms/new-console-template for more information
using AttirubuteInveonOrnek;

Console.WriteLine("Hello, World!");

Ogrenci ogr = new Ogrenci();
ogr.Bolum = "Yazılım";
ogr.adi = "ibrahim";
ogr.soyadi = "gökyar";

// fiedlar doldurulmuş mu diye kontrol eder.
if(!ZorunlulukKontrolu.Dogrula(ogr))
{
    Console.WriteLine("öğrenci bilgileri girilmesi zorunludur");
}
else
{
    Console.WriteLine("form başarılı");
}

