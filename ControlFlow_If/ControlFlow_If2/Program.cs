using System;

namespace ControlFlow_If2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama için : + ");
            Console.WriteLine("Çıkarma için : - ");
            Console.WriteLine("Çarpma için : * ");
            Console.WriteLine("Bölme için : / ");
            double sonuc = 0;
            bool ok = true;
            bool bolmehata = true;
            Console.Write("Seçiminiz : ");
            string secim = Console.ReadLine();
            Console.Write("1.sayı : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayı : ");
            int sayi2 = int.Parse(Console.ReadLine());
            if (secim == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (secim == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (secim == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (secim == "/")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("ikini sayı 0 olduğundan dolayı bölme işlemi gerçekleştirilemedi");
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
            }
            else
            {
                ok = false;
                Console.WriteLine("Hatalı bir işlem tipi seçtiniz.");
            }
            if (ok && bolmehata == false)
            {
                Console.WriteLine("İşlem sonucu : {0} {1} {2} = {3}", sayi1, secim, sayi2, sonuc);
            }
        }
    }
}
