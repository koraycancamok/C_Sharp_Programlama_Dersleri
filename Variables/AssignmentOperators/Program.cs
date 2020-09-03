using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 40;
            var b = 20;
            a += b;
            var c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
