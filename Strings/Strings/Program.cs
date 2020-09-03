using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var ad = "koray";
            var soyad = "çamok";
            //var adsoyad = "adınız : " + ad + ", " + "soyadınız : " + soyad;
            //var adsoyad = string.Format("adınız : {0}, soyadınız : {1}", ad, soyad);
            var adsoyad = $"adınız : {ad}, soyadınız : {soyad}";
            Console.WriteLine(adsoyad);
            Console.WriteLine("-------------");
            string[] adlar = {"ali", "koray", "ahmet", null};
            if (string.IsNullOrEmpty(adlar[3]))
            {
                Console.WriteLine("isim boş");
            }
            var tumadlar = string.Join("-",adlar);
            Console.WriteLine(tumadlar);     
        }
    }
}
