using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = true;
            var b = true;
            var c = false;
            var d = false;

            Console.WriteLine("&");
            Console.WriteLine(a & b);
            Console.WriteLine(a & c);
            Console.WriteLine(c & d);
            Console.WriteLine("-----");

            Console.WriteLine("|");
            Console.WriteLine(a | b);
            Console.WriteLine(a | c);
            Console.WriteLine(c | d);
            Console.WriteLine("-----");

            Console.WriteLine("^");
            Console.WriteLine(a ^ b);
            Console.WriteLine(a ^ c);
            Console.WriteLine(c ^ d);
            Console.WriteLine("-----");

            Console.WriteLine("&&");
            Console.WriteLine(a && b);
            Console.WriteLine(a && c);
            Console.WriteLine(c && d);
            Console.WriteLine("-----");

            Console.WriteLine("||");
            Console.WriteLine(a || b);
            Console.WriteLine(a || c);
            Console.WriteLine(c || d);
            Console.WriteLine("-----");

            Console.WriteLine("!");
            Console.WriteLine(!a);
            Console.WriteLine("-----");

            Console.WriteLine(!(((a & b) || c) & d));

            Console.ReadLine();
        }
    }
}
