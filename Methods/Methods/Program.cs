using System;

namespace Methods
{
    public class KrediHesabı
    {
        public string MusteriAdi;
        public string HesapNo;
        public double Limit;

        public string KrediKullan()
        {
            return string.Format("{0} miktarında kredi hesabınıza yatırıldı.", Limit);
        }
        public string KrediKullan(double miktar)
        {
            if (miktar > Limit)
            {
                return string.Format("maksimum kullanabileceğiniz kredi miktarı {0}", Limit);
            }
            return string.Format("{0} miktarındaki kredi hesabınıza yatırıldı", miktar);
        }
    }
    public class Islem
    {
        public int Toplama(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var krediHesabi = new KrediHesabı();
            //krediHesabi.MusteriAdi = "Ahemt Turan";
            //krediHesabi.HesapNo = "12313123123123";
            //krediHesabi.Limit = 20000;
            //Console.WriteLine(krediHesabi.KrediKullan(20000));

            //var krediHesabi2 = new KrediHesabı();
            //krediHesabi2.MusteriAdi = "Mehmet Turan";
            //krediHesabi2.HesapNo = "123123123123123";
            //krediHesabi2.Limit = 30000;
            //Console.WriteLine(krediHesabi2.KrediKullan());

            var islem = new Islem();
            Console.WriteLine(islem.Toplama(10, 20, 30, 50));
        }
    }
}
