using System;

namespace Deneme3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("Soy Adınızı Giriniz: ");
            string soyad = Console.ReadLine();

            Console.Write("Doğum Yılınızı giriniz: ");
            string yilStr = Console.ReadLine();

            Console.Clear();

            int yil = Convert.ToInt32(yilStr);
            int mevcutYil = DateTime.Now.Year;
            int yas = mevcutYil - yil;

            string mesaj = (isim + " " + soyad + " " + yas + " yaşındasın sen şimdi naneyi yimedin migg");
            Console.Write(mesaj);
            Console.ReadLine();
        }
    }
}
