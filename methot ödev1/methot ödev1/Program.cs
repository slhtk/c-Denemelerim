using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methot_ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAd = string.Empty;
            string ogrenciSoyad = string.Empty;
            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            decimal ortalama = 0;
            Console.WriteLine("Ortalamasını hesaplamak istediğiniz öğrencinin bilgilerini giriniz");
            Console.Write("Ad :");
            ogrenciAd = Console.ReadLine();
            
            Console.Write("Soyad :");
            ogrenciSoyad = Console.ReadLine();
            
            Console.WriteLine("Not1 :");
            not1 = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Not2 :");
            not2 = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Not3 :");
            not3 = decimal.Parse(Console.ReadLine());

            
            Ogrenci.OgrenciHesapla(ogrenciAd, ogrenciSoyad, not1, not2, not3);

        }        
    }
}
