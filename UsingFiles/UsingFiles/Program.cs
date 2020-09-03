using System;
using System.IO;

namespace UsingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\deneme/1.txt";
            var path2 = @"C:\deneme2/1.txt";
            //File.Create(path);
            //if (File.Exists(path2))
            //{
            //    Console.WriteLine("aynı dizinde dosya zaten mevcut");
            //}
            //else
            //{
            //    File.Copy(path, path2, true);
            //}
            //var text = File.ReadAllText(path);
            //Console.WriteLine(text);

            FileInfo fileınfo = new FileInfo(path);
            fileınfo.CopyTo(path2,true);
            fileınfo.Delete();
        }
    }
}
