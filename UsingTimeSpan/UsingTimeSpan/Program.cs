using System;

namespace UsingTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts1 = new TimeSpan(2, 10, 50);
            TimeSpan ts2 = new TimeSpan(1, 0, 0);
            TimeSpan ts3 = TimeSpan.FromHours(1);
            Console.WriteLine("saniye : {0}",ts1.Seconds);
            Console.WriteLine("dakika : {0}",ts1.Minutes);
            Console.WriteLine("saat : {0}",ts1.Hours);
            Console.WriteLine("toplam dakika : {0}",ts1.TotalMinutes);

            //DateTime now1 = DateTime.Now;
            //DateTime now2 = DateTime.Now.AddHours(2);
            //TimeSpan timespan = now2 - now1;
            //Console.WriteLine("geçen süre : {0}",timespan.TotalMilliseconds);
        }
    }
}
