using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    string sayi = "256,50";
                    double i = double.Parse(sayi);
                    //long i = Convert.ToInt64(sayi);
                    //double i = Convert.ToDouble(sayi);
                    //string sayi = "true";
                    //bool i = bool.Parse(sayi);
                    //bool i = Convert.ToBoolean(sayi);
                    Console.WriteLine(i);
                }
                catch (Exception)
                {
                    Console.WriteLine("Tür dönüşüm hatası");
                }                   
            Console.ReadLine();
        }
    }
}
