using System;
using System.IO;

namespace UsingPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\drive";
            string[]  files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine("dosya adı : {0}",Path.GetFileName(item));
                Console.WriteLine("dosya uzantısı : {0}",Path.GetExtension(item));
                Console.WriteLine("sadece dosya adı : {0}",Path.GetFileNameWithoutExtension(item));
                Console.WriteLine("üst klasör : {0}",Path.GetDirectoryName(item));
            }
            var filename = Path.GetRandomFileName();
            Console.WriteLine(filename);
        }
    }
}
