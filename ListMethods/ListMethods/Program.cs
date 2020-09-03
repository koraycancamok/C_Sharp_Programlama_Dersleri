using System;
using System.Collections;
using System.Collections.Generic;

namespace ListMethods
{
    class Ogrenci
    {
        public string Ad;
        public string Soyad;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var sayilar = new List<int>() { 10, 20, 50, 60 };
            //sayilar.Add(70);
            //sayilar.Add(80);
            //sayilar.Add(90);
            //sayilar.Add(100);
            //var sayilar2 = new int[3] { 1000, 2000, 3000 };
            //sayilar.AddRange(sayilar2);
            //sayilar.Insert(2, 4000);
            //sayilar.InsertRange(0, sayilar2);
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //Console.WriteLine("----------------");
            //var isimler = new List<string>() { "Ayşe", "Pınar", "Cengiz" };
            //int index = isimler.IndexOf("Cengiz");
            //if (isimler.Contains("Sadık"))
            //{
            //    Console.WriteLine("Listede eleman zaten mevcut");
            //}
            //else
            //{
            //    isimler.Add("Sadık");
            //}
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //isimler.Sort();
            //Console.WriteLine("----------------");
            //isimler.Remove("Cengiz");
            //isimler.RemoveAt(0);
            //isimler.Clear();
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            var ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci(){Ad="Ayşe",Soyad="Turan"},
                new Ogrenci(){Ad="Pınar",Soyad="Turan"},
                new Ogrenci(){Ad="Cengiz",Soyad="Yılmaz"},
            };
            ogrenciler.Add(new Ogrenci() { Ad = "Ahmet", Soyad = "Turan" });
            var ogrenci = ogrenciler[0];
            ogrenciler.Remove(ogrenci);
            ogrenciler.RemoveAt(0);
            var cengiz = ogrenciler.Find(i=>i.Ad=="Ali");
            if (ogrenciler.Contains(cengiz))
            {
                Console.WriteLine("aynı eleman mevcut");
            }
            else
            {
                ogrenciler.Add(new Ogrenci() { Ad = "Ali", Soyad = "Yılmaz" });
            }
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                if (ogrenciler[i].Ad == "Cengiz")
                {
                    ogrenciler.Remove(ogrenciler[i]);
                }
            }
            foreach (var item in ogrenciler)
            {
                if (item.Ad== "Cengiz")
                {
                    item.Ad = "CENGİZ";
                }
            }
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Ad);
            }
        }
    }
}
