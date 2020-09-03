using System;

namespace ForLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("başlangıc değeri : ");
            int baslangic = int.Parse(Console.ReadLine());
            Console.Write("bitiş değeri : ");
            int bitis = int.Parse(Console.ReadLine());
            Console.Write("artış miktarı : ");
            int artis = int.Parse(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;
            int carpım = 1;
            int karesi = 1;
            for (int i = baslangic; i <= bitis; i = i + artis)
            {
                sayac++;
                toplam = toplam + i;
                carpım = carpım * i;
                karesi = i * i;
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}. sayı : {1} sayı çift ve karesi {2}", sayac, i, karesi);
                }
                else
                {
                    Console.WriteLine("{0}. sayı : {1} sayı tek ve karesi {2}", sayac, i, karesi);
                }                           
            }
            Console.WriteLine("toplam değer : {0}",toplam);
            Console.WriteLine("çarpım değer : {0}",carpım);

            Console.ReadLine();
        }
    }
}
