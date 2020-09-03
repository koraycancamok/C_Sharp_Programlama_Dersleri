using System;

namespace doWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim;
            double bakiye = 0;
            do
            {
                Console.Write("1-bakiye görüntüleme \n 2-para yatırma \n 3-para çekme \n 4-çıkış \n");
                Console.Write("seçiminiz : ");
                secim = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------");
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("bakiyeniz : {0} TL", bakiye);
                        if (bakiye < 500)
                        {
                            Console.WriteLine("bakiyeniz 500 TL'nin altına düşmüştür.");
                        }
                        Console.WriteLine("--------------------------------------------------");
                        break;
                    case "2":
                        Console.Write("ne kadar para yatırmak istiyorsunuz : ");
                        double miktar = double.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------");
                        bakiye += miktar;
                        break;
                    case "3":
                        Console.Write("ne kadar para çekmek istiyorsunuz : ");
                        double eksilen = double.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------");
                        if (eksilen > bakiye)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            Console.WriteLine("--------------------------------------------------");
                        }
                        else
                        {
                            bakiye -= eksilen;
                        }
                        break;
                }
            } while (secim != "4");
            
            Console.ReadLine();
        }
    }
}
