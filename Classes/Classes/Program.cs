using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba opel = new Araba();
            opel.Marka = "Opel";
            opel.Model = "Corsa";
            opel.Renk = "Kırmızı";
            opel.Agirlik = 1250;
            opel.Start();
            opel.Hizlan();
            opel.Yavasla();
            opel.Stop();
            Console.WriteLine("-----------------");
            Araba mazda = new Araba();
            mazda.Marka = "Mazda";
            mazda.Model = "CX 3";
            mazda.Renk = "Beyaz";
            mazda.Agirlik = 1500;
            mazda.Start();
            mazda.Hizlan();
            mazda.Yavasla();
            mazda.Stop();
            Console.WriteLine("-----------------");
            int sonuc = Hesaplama.Toplama(10, 20);
            Console.WriteLine(sonuc);
        }
    }
}
