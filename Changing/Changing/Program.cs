using System;

namespace Changing
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs = "C# Programlama";
            //string kurs2 = kurs.Insert(0, "Sıfırdan ");
            //int index = kurs2.IndexOf("Programlama") + "Programlama".Length;
            //string kurs3 = kurs2.Insert(index, " Eğitimi");
            //Console.WriteLine(kurs3);

            //string kurs = "Sıfırdan C# Programlama Eğitimi";
            //string url = kurs.Replace("ı", "i").Replace(" ", "-").Replace("#", "Sharp").Replace("ğ", "g");
            //Console.WriteLine(url.ToLower());

            //string kurs = "Sıfırdan C# Programlama Eğitimi Sıfırdan C# Programlama Eğitimi Sıfırdan C# Programlama Eğitimi Sıfırdan C# Programlama Eğitimi";
            //string kurs2 = kurs.Length > 20 ? kurs.Substring(0, 20) + "..." : kurs;
            //Console.WriteLine(kurs2);

            //string kurs = " Sıfırdan C# Programlama Eğitimi ";
            //string kurs2 = kurs.Trim();
            //Console.WriteLine(kurs2);

            Console.Write("adınızı giriniz : ");
            string ad = Console.ReadLine();
            Console.WriteLine(ad.Trim().Length);
        }
    }
}
