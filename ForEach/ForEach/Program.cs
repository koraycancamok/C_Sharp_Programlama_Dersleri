using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad = "koraycan";
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}

            int[] sayilar = { 10, 12, 2, 5, 7, 67, 56 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("---------------");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
