using System;
using System.IO;

namespace UsingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\altklasor";
            var path2 = @"C:\deneme";
            var path3 = @"C:\deneme1";
            //Console.WriteLine("şu an çalışılan klasör : {0}",Directory.GetCurrentDirectory());
            //Console.WriteLine("c sürücüsündeki klasörler");
            //Console.WriteLine("--------------");
            //string[] klasorler = Directory.GetDirectories(path);
            //foreach (var item in klasorler)
            //{
            //    Console.WriteLine(item);
            //}
            //if (!Directory.Exists(path2))
            //{
            //    Directory.CreateDirectory(path2);
            //}
            //Directory.Move(path2, path3);
            //Directory.Delete(path3);

            DirectoryInfo directoryinfo = new DirectoryInfo(path);
            //directoryinfo.CreateSubdirectory("altklasor");
            if (directoryinfo.Exists)
            {
                directoryinfo.Delete();
            }
        }
    }
}
