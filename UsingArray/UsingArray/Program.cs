using System;

namespace UsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sehirler = new string[3];
            //sehirler[0] = "Ankara";
            //sehirler[1] = "İzmir";
            //sehirler[2] = "İstanbul";
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            Console.Write("Kaç adet sayı girmek istiyorsunuz : ");
            int adet = int.Parse(Console.ReadLine());
            Console.WriteLine("---------");
            byte[] sayilar = new byte[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}.sayıyı giriniz :", i + 1);
                sayilar[i] = byte.Parse(Console.ReadLine());
            }
            int toplam = 0;
            Console.WriteLine("---------");
            Console.WriteLine("Girilen sayılar.....");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0} sayı :{1}",i+1,sayilar[i]);
                toplam += sayilar[i];
            }
            double ortalama = toplam / Convert.ToDouble(sayilar.Length);
            Console.WriteLine("---------");
            Console.WriteLine("Sayıların toplamı : {0}",toplam);
            Console.WriteLine("Sayıların Ortalaması : {0}",ortalama);
        }
    }
}
