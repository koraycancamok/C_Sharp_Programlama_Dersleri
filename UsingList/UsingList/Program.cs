using System;
using System.Collections;
using System.Collections.Generic;

namespace UsingList
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
            var sayilar = new List<int>() { 10, 20, 50, 60 };
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine(sayilar[2]);
            Console.WriteLine("----------");
            var isimler = new List<string>() {"Ayşe", "Pınar", "Cengiz"};
            isimler.Add("Murat");
            isimler.Add("Ali");
            isimler.Add("Çınar");
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(isimler[2]);
            Console.WriteLine("----------");
            var ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() {Ad = "Ayşe", Soyad = "Turan" },
                new Ogrenci() {Ad = "Pınar", Soyad = "Turan" },
                new Ogrenci() {Ad = "Cengiz", Soyad = "Yılmaz" },
            };
            ogrenciler.Add(new Ogrenci() {Ad = "Murat", Soyad = "Yılmaz" });
            ogrenciler.Add(new Ogrenci() {Ad = "Ali", Soyad = "Turan" });
            ogrenciler.Add(new Ogrenci() {Ad = "Çınar", Soyad = "Turan" });
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine("ogrenci adı : {0} ogrenci soyadı : {1}",ogrenci.Ad,ogrenci.Soyad);
            }
            Console.WriteLine(ogrenciler[2].Ad);
        }
    }
}
