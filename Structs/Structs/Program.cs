using System;

namespace Structs
{
    public struct Dikdortgen
    {
        public int kisa;
        public int uzun;
        public int Alan()
        {
            return kisa* uzun;
        }
        public int Cevre()
        {
            return 2 * (kisa + uzun);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen _dikdortgen = new Dikdortgen();
            _dikdortgen.kisa = 50;
            _dikdortgen.uzun = 70;
            int sonuc1 = _dikdortgen.Alan();
            Console.WriteLine(sonuc1);

            Dikdortgen _kare = new Dikdortgen();
            _kare.kisa = 50;
            _kare.uzun = 50;
            int sonuc2 = _kare.Alan();
            Console.WriteLine(sonuc2);

            Console.WriteLine("-------------");

            Console.WriteLine(_dikdortgen.Cevre());
            Console.WriteLine(_kare.Cevre());
        }
    }
}
