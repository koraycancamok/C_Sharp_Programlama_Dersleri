using System;

namespace Enum
{
    class Program
    {
        public enum OdemeYontemleri : byte
        {
            KrediKarti = 1,
            Havale = 2,
            KapidaOdeme = 3,
        }
        static void Main(string[] args)
        {
            //var kredikartı = OdemeYontemleri.KrediKarti;
            //var odemeid = (int)kredikartı;
            //Console.WriteLine((OdemeYontemleri)odemeid);
            //Console.WriteLine(odemeid);
            //Console.WriteLine(kredikartı);

            //string secim = " ";
            //do
            //{     
            //    Console.Write("ödeme tipini giriniz (Kredi 1, Havale 2, Kapıda 3) : ");
            //    var odemetipi = byte.Parse(Console.ReadLine());   
            //    if (odemetipi < 4)
            //    {
            //        switch (odemetipi)
            //        {
            //            case (byte)OdemeYontemleri.KrediKarti:
            //                Console.WriteLine("yapılan ödeme {0}", OdemeYontemleri.KrediKarti);
            //                break;
            //            case (byte)OdemeYontemleri.Havale:
            //                Console.WriteLine("yapılan ödeme {0}", OdemeYontemleri.Havale);
            //                break;
            //            case (byte)OdemeYontemleri.KapidaOdeme:
            //                Console.WriteLine("yapılan ödeme {0}", OdemeYontemleri.KapidaOdeme);
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("yanlış ödeme tipi");
            //    }
            //    Console.Write("devam ");
            //    secim = Console.ReadLine();
            //} while (secim == "e");
            //Console.WriteLine("bitti");

            Console.ReadLine();
        }
    }
}
