using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Toplama=: ");
            Console.WriteLine("2 - Çıkartma: ");
            Console.WriteLine("3 - Çarpma: ");
            Console.WriteLine("4 - Bölme: ");
            Console.Write("Seçiminizi yapınız: ");
            string kullanıcıSecimi = Console.ReadLine();
            decimal sayi1 = 0;
            decimal sayi2 = 0;

            if (kullanıcıSecimi == "1" || kullanıcıSecimi == "2" || kullanıcıSecimi == "3" || kullanıcıSecimi == "4")
            {
                Console.WriteLine("1. sayıyı giriniz: ");
                string s1 = Console.ReadLine();
                Console.WriteLine("2. sayıyı giriniz: ");
                string s2 = Console.ReadLine();

                sayi1 = Convert.ToDecimal(s1);
                sayi2 = Convert.ToDecimal(s2);
            }

            if (kullanıcıSecimi == "1")
            {
                decimal toplam = sayi1 + sayi2;
                Console.WriteLine("toplama sonucu = " + toplam);
            }
            else if (kullanıcıSecimi == "2")
            {
                decimal çıkart = sayi1 - sayi2;
                Console.WriteLine("Çıkartma sonucu = " + çıkart);

            }
            else if (kullanıcıSecimi == "3")
            {
                decimal carpma = sayi1 * sayi2;
                Console.WriteLine("carpma sonucu = " + carpma);

            }
            else if (kullanıcıSecimi == "4")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölen sayı 0 olamaz");
                }
                else
                {
                    decimal bolme = sayi1 / sayi2;
                    Console.WriteLine("bölme sonucu = " + bolme);
                }


            }


            else
            {
                Console.WriteLine("hatalı giriş yaptınız 1-4 arası bir seçim yapmalısınız ");

            }
            Console.WriteLine("Uygulama sonu");
            Console.ReadLine();

        }
    }
}
