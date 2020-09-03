using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenci = new string[2] { "Yasin", "Cem" };
            var ogrenci2 = new string[4] { "Hasan", "Ali", "Ayşe", "Yağmur" };
            //Array.Copy(ogrenci, ogrenci2, 2);
            ogrenci.CopyTo(ogrenci2, 2);
            Console.WriteLine("sıralamadan önce");
            foreach (var item in ogrenci2)
            {
                Console.WriteLine(item);
            }
            //Array.Clear(ogrenci2, 2, 2);
            Console.WriteLine("sıralamadan sonra");
            Array.Sort(ogrenci2);
            Array.Reverse(ogrenci2);
            foreach (var item in ogrenci2)
            {
                Console.WriteLine(item);
            }
            var aranacakkelime = Array.IndexOf(ogrenci, "Cem");
            ogrenci.SetValue("Ali", 0);
            Console.WriteLine(ogrenci.GetValue(0));
            Console.WriteLine("Dizi Boyutu : {0}",ogrenci.Rank);
            Console.WriteLine("Dizi eleman sayısı (length) : {0}",ogrenci.Length);
            Console.WriteLine("Dizi eleman sayısı (GetLength) : {0}",ogrenci.GetLength(0));
            Console.WriteLine("Aranacak kelime: {0}",aranacakkelime);

            var ogrenciler = new string[2, 3]
            {
                {"Çınar", "Yiğit", "Ali"},
                {"Yağmur", "Ata", "Canan"}
            };
            ogrenciler.SetValue("Can",0,1);
            Console.WriteLine(ogrenciler.GetValue(0,1));
            Console.WriteLine("Dizi Boyutu : {0}", ogrenciler.Rank);
            Console.WriteLine("Dizi eleman sayısı : {0}", ogrenciler.Length);
            Console.WriteLine("Dizi satır sayısı (GetLength) : {0}", ogrenciler.GetLength(0));
            Console.WriteLine("Dizi sütun sayısı (GetLength) : {0}", ogrenciler.GetLength(1));
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {

                }
            }
        }
    }
}
