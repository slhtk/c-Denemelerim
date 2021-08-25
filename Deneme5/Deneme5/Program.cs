using System;

namespace Deneme5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Giriniz :");
            string S1 = Console.ReadLine();
            Console.WriteLine("2.Sayıyı Giriniz: ");
            string S2 = Console.ReadLine();

            decimal sayi1 = Convert.ToDecimal(S1);
            decimal sayi2 = Convert.ToDecimal(S2);
            decimal Toplam = sayi1 + sayi2;



            // Şart sağlanırsa consola yazılır. sağlanmazsa bir alt satıra iner.
            if (Toplam >= 50) // eğer
            {
                Console.WriteLine("Tolam değeri 50 ye eşit veya büyük ");
            }

            // Şart sağlanırsa consola yazılır.Sağlanmazsa bir alt satıra iner.

            else if (Toplam >= 40) // Değilse eger..
            {
                Console.WriteLine("Toplam değeri 40 eşit veya küçük ");
            }

            else
            {
                Console.WriteLine("Toplam değeri 40 dan küçüktür.");
            }
            Console.ReadLine();

        }
    }
}
