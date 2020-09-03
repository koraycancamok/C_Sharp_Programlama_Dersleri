using System;

namespace WhileLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            char secim = 'e';
            int hak = 5;
            int sayac = 0;
            int puan = 100;
            int tutulan = (new Random()).Next(1, 10);
            while (hak > 0)
            {
                sayac++;
                Console.Write("sayı giriniz : ");
                sayi = int.Parse(Console.ReadLine());
                if (tutulan == sayi)
                {
                    Console.WriteLine("tebrik ederim {0}. defada bildiniz. puanınız {1}", sayac, puan - (sayac * 20));
                    Console.Write("devam etmek istiyor musunuz? : ");
                    secim = char.Parse(Console.ReadLine());
                    if (secim == 'e')
                    {
                        hak = 6;
                        sayac = 0;
                        tutulan = (new Random()).Next(1, 10);
                    }
                    else
                    {
                        hak = -1;
                    }
                }
                else
                {
                    if (tutulan > sayi)
                    {
                        Console.WriteLine("yukarı");
                    }
                    else
                    {
                        Console.WriteLine("aşağı");
                    }
                }
                hak--;
                if (hak == 0)
                {
                    Console.WriteLine("oyun bitti");
                    Console.Write("devam etmek istiyor musunuz? : ");
                    secim = char.Parse(Console.ReadLine());
                    if (secim == 'e')
                    {
                        hak = 5;
                        tutulan = (new Random()).Next(1, 10);
                    }
                    else
                    {
                        hak = -1;
                    }
                }        
            }
        }
    }
}
