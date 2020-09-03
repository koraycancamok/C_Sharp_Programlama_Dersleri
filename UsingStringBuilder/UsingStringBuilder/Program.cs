using System;
using System.Text;

namespace UsingStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder str = new StringBuilder();

            //str.Append("C# Programlama Eğitimine Hoşgeldiniz");
            //Console.WriteLine(str);

            //str.Replace("Programlama", "Yazılım");
            //Console.WriteLine(str);

            //str.Insert(0, "Sıfırdan ");
            //Console.WriteLine(str);

            //str.Remove(0, 9);
            //Console.WriteLine(str);

            //Console.WriteLine(str.Capacity);

            string str1 = string.Empty;
            DateTime baslangic = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                str1 += i;
            }
            DateTime bitis = DateTime.Now;
            double sure = (bitis - baslangic).TotalSeconds;
            Console.WriteLine("string işlemi {0} sürdü",sure);

            StringBuilder str2 = new StringBuilder();
            baslangic = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                str2.Append(i);
            }
            bitis = DateTime.Now;
            sure = (bitis - baslangic).TotalSeconds;
            Console.WriteLine("stringbuilder işlemi {0} sürdü", sure);
        }
    }
}
