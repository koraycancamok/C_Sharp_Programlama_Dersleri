using System;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = new DateTime(2017,5,9);
            DateTime now = DateTime.Now;
            Console.WriteLine("saat : {0}",now.Hour);
            Console.WriteLine("gün : {0}", now.Day);
            Console.WriteLine("dakika : {0}", now.Minute);
            Console.WriteLine("dakika : {0}", now.Year);
            DateTime minutes = now.AddHours(10);
            Console.WriteLine("saat : {0}",minutes.Hour);

            Console.WriteLine("------");

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
        }
    }
}
