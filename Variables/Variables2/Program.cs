using System;

namespace variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte kilo = -128; // "u" negatiflik için
            Console.WriteLine(kilo);

            uint arackm = 100000; // "u" negatiflik için
            Console.WriteLine(arackm);

            ulong musteri_id = 10000000; // "u" negatiflik için
            Console.WriteLine(musteri_id);

            bool satistami = false;
            Console.WriteLine(satistami);

            decimal maas = 3000.54m;
            Console.WriteLine(maas);

            string adsoyad = "Koray Can Çamok";
            Console.WriteLine(adsoyad);

            char subekodu = 'A';
            Console.WriteLine(subekodu);
        }
    }
}
