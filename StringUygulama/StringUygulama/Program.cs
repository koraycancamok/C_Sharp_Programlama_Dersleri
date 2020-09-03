using System;

namespace StringUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var cumle = "Eğer bir cümlenin toplam karakter sayısı belirtilen bir karakter sayısıdan fazla ise cümleyi kesmemiz gerekiyor.";
            var ozet = HelperMethod.Ozetle(cumle,20);
            Console.WriteLine(ozet);
        }
    }
}
