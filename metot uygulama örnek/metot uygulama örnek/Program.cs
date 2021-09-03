using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_uygulama_örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            M.menuHazırla();
            YenidenIslemYap:
            int kullaniciSecim = int.Parse(Console.ReadLine());
            
            Console.WriteLine("1. sayıyı giriniz : ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            decimal kullaiciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch (kullaniciSecim)
            {
                case 1:
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaiciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaiciSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = M.cıkartmaIslemi(kullaniciSayi1, kullaiciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaiciSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaiciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaiciSayi2, sonuc, "/");
                    break;
                case 4:
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaiciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaiciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Seçilen deger liste içerisinde bulunmamaktadır.");
                    Console.WriteLine("Tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;
            }
            Console.WriteLine("Yenıden işlem yapmak istiyormusunuz? [E/H]");
            string EH = Console.ReadLine();
            if (EH=="E")
            {
                goto YenidenIslemYap;
            }
            Console.ReadLine();
        }
    }
}
