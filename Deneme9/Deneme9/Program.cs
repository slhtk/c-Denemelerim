using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not Ortalamasını hesaplayan Uygulama
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            Console.WriteLine("Not Ortalamasını Hesapla ");
            Console.Write("Adınızı Giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Soy Adınızı Giriniz:");
            string soyad = Console.ReadLine();
            Console.Write("Vize1 Notunuzu Giriniz: ");
            string vize1 = Console.ReadLine();
            Console.Write("Vize2 Notunuzu Giriniz: ");
            string vize2 = Console.ReadLine();
            Console.Write("Final Notunuzu Giriniz: ");
            string final = Console.ReadLine();

            s1 = Convert.ToDouble(vize1);
            s2 = Convert.ToDouble(vize2);
            s3 = Convert.ToDouble(final);

            double ortalama = (s1 + s2 + s3) / 3;
            if (ortalama < 45)
            {
                Console.WriteLine(ad + " " + soyad + " ortalamanız " + ortalama + " kaldınız. ");
            }
            else if (ortalama == 45 || ortalama < 70)
            {
                Console.WriteLine(ad + " " + soyad + " ortalamanız " + ortalama + " orta ile geçtiniz. ");
            }
            else if (ortalama == 70 || ortalama < 90)
            {
                Console.WriteLine(ad + " " + soyad + " ortalamanız " + ortalama + " iyi ile geçiniz. ");
            }
            else if (ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine(ad + " " + soyad + " ortalamanız " + ortalama + " başarılı tebrikler. ");
            }
            else
            {
                Console.WriteLine("Notlarınız kontrol ediniz eksik veya yanlış not girdiniz.");
            }
            Console.ReadLine();
        }

    }
}
