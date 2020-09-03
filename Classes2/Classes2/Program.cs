using System;
using System.Collections.Generic;

namespace Classes2
{
    public class Kutu
    {
        public int En;
        public int Boy;
        public int Derinlik;

        public String Yazdir()
        {
            return string.Format("En : {0} Boy : {1} Derinlik : {2}", En, Boy, Derinlik);
        }

        public string Hacim()
        {
            return string.Format("Hacim : {0}", En * Boy * Derinlik);
        }
    }
    public class Urun
    {
        public string UrunAdi;
        public double Fiyat;
    }
    public class UrunManager
    {
        public static List<Urun> UrunleriGetir()
        {
            //Veritabanına bağlan ve ürünleri getir.
            var urunler = new List<Urun>()
            {
                new Urun() { UrunAdi = "Samsung S5", Fiyat = 1000 },
                new Urun() { UrunAdi = "Samsung S6", Fiyat = 2200 },
                new Urun() { UrunAdi = "Samsung S7", Fiyat = 3000 },
                new Urun() { UrunAdi = "Samsung S8", Fiyat = 4000 },
                new Urun() { UrunAdi = "Iphone 6S", Fiyat = 3000 },
                new Urun() { UrunAdi = "Iphone 7", Fiyat = 4000 }
            };
            return urunler;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Kutu kutu1 = new Kutu();
            //kutu1.En = 10;
            //kutu1.Boy = 10;
            //kutu1.Derinlik = 10;
            //Console.WriteLine(kutu1.Yazdir());
            //Console.WriteLine(kutu1.Hacim());

            //UrunManager _urunManager = new UrunManager();
            var urunler = UrunManager.UrunleriGetir();
            foreach (var urun in urunler)
            {
                Console.WriteLine($"ürün adı : {urun.UrunAdi} fiyat : {urun.Fiyat}");
            }
        }
    }
}
