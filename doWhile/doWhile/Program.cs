using System;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string password = "";
            byte hak = 2;
            do
            { 
                if (hak == 0)
                {
                    break;
                }
                Console.Write("kullanıcı adı : ");
                username = Console.ReadLine();
                Console.Write("parola : ");
                password = Console.ReadLine();
                hak--;
            } while (username != "koray" || password != "12345");
            if (hak == 0)
            {
                Console.WriteLine("hakkınız bitti");
            }
            else
            {
                Console.WriteLine("giriş başarılı");
            }

            Console.ReadLine();
        }
    }
}
