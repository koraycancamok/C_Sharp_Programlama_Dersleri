using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "b";
            //string str2 = "a";
            //if (str1.Equals(str2) == true)
            //{
            //    Console.WriteLine("değerler eşit");
            //}
            //int sonuc = string.Compare(str1, str2);
            //if (sonuc == 0)
            //{
            //    Console.WriteLine("değerler eşit");
            //}
            //else if (sonuc == 1)
            //{
            //    Console.WriteLine("str2 str1'den alfabetik olarak önden gelir");
            //}
            //else if (sonuc == -1)
            //{
            //    Console.WriteLine("str1 str2'den alfabetik olarak önden gelir");
            //}

            string _email = "koraycan@gmail.com";
            string _parola = "123";

            Console.Write("Email giriniz : ");
            string email = Console.ReadLine();

            Console.Write("Parola giriniz : ");
            string parola = Console.ReadLine();

            if (_email.Equals(email) && _parola.Equals(parola))
            {
                Console.WriteLine("sisteme giriş yaptınız");
            }
            else
            {
                Console.WriteLine("hatalı kullanıcı adı veya parola");
            }
        }
    }
}
