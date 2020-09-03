using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            var sonuc = (sayi % 2 == 0) ?
                (sayi > 0 ? "sayı çift pozitif" : "sayı çift negatif") :
                (sayi > 0 ? "sayı tek pozitif" : "sayı tek negatif");
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
