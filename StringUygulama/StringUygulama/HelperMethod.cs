using System;
using System.Collections.Generic;
using System.Text;

namespace StringUygulama
{
    public class HelperMethod
    {
        public static string Ozetle(string str, int maxKarakter = 30)
        {
            if (maxKarakter > str.Length)
                return str;

            //var ozet = cumle.Substring(0, maxKarakter) + "...";
            //Console.WriteLine(ozet);
            var kelimeler = str.Split(' ');
            var toplamkarakter = 0;
            var ozetkelimeler = new List<string>();
            foreach (var kelime in kelimeler)
            {
                ozetkelimeler.Add(kelime);
                toplamkarakter += kelime.Length;
                if (toplamkarakter > maxKarakter)
                    break;
            }
            return string.Join(" ", ozetkelimeler) + "...";
        }
    }
}
