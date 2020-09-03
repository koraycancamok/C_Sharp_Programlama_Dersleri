using System;

namespace AritmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 15;
            var b = 4;
            var c = 3;

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine((float)a/(float)b);
            Console.WriteLine((a+b)*c);
            Console.WriteLine(a%2);
            Console.WriteLine(b%2);
            Console.WriteLine(c%2);
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(b--);
            Console.WriteLine(b);
            Console.WriteLine(c=b++);

            int d = 3, e = 5;

            Console.WriteLine(d=++e);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}
