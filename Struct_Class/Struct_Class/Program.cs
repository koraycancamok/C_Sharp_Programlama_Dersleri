using System;

namespace Struct_Class
{
    class Program
    {
        class Urun
        {
            public string UrunAdi;
            public float Fiyat;
        }
        static void Main(string[] args)
        {
            Urun iphone = new Urun();
            iphone.UrunAdi = "Iphone 6S";
            iphone.Fiyat = 2500;
            UrunGetir(iphone);
            UrunGuncelle(iphone);
            UrunGetir(iphone);
        }
        static void UrunGetir(Urun urun)
        {
            Console.WriteLine($"urun adı : {urun.UrunAdi}, fiyat : {urun.Fiyat}");
        }
        static void UrunGuncelle(Urun urun)
        { 
            urun.Fiyat *= 1.5f; 
        }
    }
}
