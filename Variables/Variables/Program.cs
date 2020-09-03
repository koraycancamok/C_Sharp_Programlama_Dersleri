using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi = 10;
            short sayi2 = 500;
            int sayi3 = 30000;
            long sayi4 = 10000000;

            float sayi5 = 2.5f;
            double sayi6 = 12.5;
            decimal sayi7 = 125.56m;

            char character = 'A';
            string adsoyad = "Koray Can Çamok";

            bool isOk = true;

            const double pi = 3.14;

            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);
            Console.WriteLine(sayi4);

            Console.WriteLine(sayi5);
            Console.WriteLine(sayi6);
            Console.WriteLine(sayi7);

            Console.WriteLine(character);
            Console.WriteLine(adsoyad);

            Console.WriteLine(isOk);

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}
