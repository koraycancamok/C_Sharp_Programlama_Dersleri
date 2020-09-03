using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Araba
    {
        public string Marka;
        public string Model;
        public string Renk;
        public int Agirlik;
        public void Start()
        {
            Console.WriteLine("{0} {1} çalıştı", Marka, Model);
        }
        public void Hizlan()
        {
            Console.WriteLine("{0} {1} hızlandı", Marka, Model);
        }
        public void Yavasla()
        {
            Console.WriteLine("{0} {1} yavaşlıyor", Marka, Model);
        }
        public void Stop()
        {
            Console.WriteLine("{0} {1} durdu", Marka, Model);
        }
    }
}
