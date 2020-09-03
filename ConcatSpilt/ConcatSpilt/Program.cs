using System;

namespace ConcatSpilt
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad = "koray";
            //string soyad = " çamok";
            //string adsoyad = string.Concat(ad, soyad, "istanbul", "da", "yaşamaktayım");
            //Console.WriteLine(adsoyad);

            //string[] kisiler = {"ahmet", "ali", "hasan"};
            //string adlar = string.Join("--", kisiler);
            //Console.WriteLine(adlar);

            //string adlar = "ahmet-mehmet-hasan";
            //string[] isimler = adlar.Split('-');
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            Console.Write("ürün kodunu giriniz : ");
            string urunkodu = Console.ReadLine();
            int basamak = urunkodu.Length;
            if (basamak<8)
            {
                urunkodu = urunkodu.PadLeft(8, '0');
            }
            Console.WriteLine(urunkodu);
        }
    }
}
