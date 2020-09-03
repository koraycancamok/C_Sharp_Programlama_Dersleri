using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan masaüstü yayıncılık yazılımları ile popüler olmuştur.";
            int index = str.IndexOf("baskı");
            string str2 = str.Substring(index);
            Console.WriteLine(str2);

            //string site = "www.edudrive.com";
            //string email = "koray@gmail.com";
            //if (email.Contains("@"))
            //{
            //    Console.WriteLine("düzgün bir eposta girildi");
            //}
            //else
            //{
            //    Console.WriteLine("eposta adresinizi düzgün giriniz");
            //}
            //if (site.StartsWith("www") == true)
            //{
            //    Console.WriteLine("site adresi düzgün girildi");
            //}
            //else
            //{
            //    Console.WriteLine("geçerli bir site adresi giriniz.");
            //}
            //if (site.EndsWith("com") == true)
            //{
            //    Console.WriteLine("site adresi düzgün girildi");
            //}
            //else
            //{
            //    Console.WriteLine("geçerli bir site adresi giriniz.");
            //}
        }
    }
}
