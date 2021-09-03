using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methot_ödev1
{
    public class Ogrenci
    {
        public static void OgrenciHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3)
        {
            Console.WriteLine("Ögrenci bilgileri aşagıdaki gibidir:");
            Console.WriteLine("Ad Soyad: {0} {1}", ad, soyad);
            decimal ortalama = (not1 + not2 + not3) / 3;
            if (ortalama<45)
            {
                Console.WriteLine("Ortalama degeriniz: {0}-Kaldınız", ortalama);
            }
            else
            {
                Console.WriteLine("Ortalama degeriniz: {0}-Gectiniz", ortalama);
            }
            Console.ReadLine();
        }
    }
}
