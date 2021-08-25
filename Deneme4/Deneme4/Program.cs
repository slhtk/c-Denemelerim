using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme4
{
    class Program
    {
        static void Main(string[] args)
        {
            //operatörler 
            Console.WriteLine("1.sayıyı Giriniz: ");
            string strS1 = Console.ReadLine();
            Console.Write("2.sayıyı Giriniz: ");
            string strS2 = Console.ReadLine();

            decimal S1 = Convert.ToDecimal(strS1);
            decimal S2 = Convert.ToDecimal(strS2);

            decimal sonucTopla = S1 + S2;
            decimal sonucCikar = S1 - S2;
            decimal sonucBol = S1 / S2;
            decimal sonucCarp = S1 * S2;
            decimal sonucMod = S1 % S2;

            Console.WriteLine("Toplam Sonucu = "+ sonucTopla);
            Console.WriteLine("Çıkartma Sonucu = "+sonucCikar);
            Console.WriteLine("Bölüm Sonucu ="+sonucBol);
            Console.WriteLine("Çarpım Sonucu = "+sonucCarp);
            Console.WriteLine("Mod Sonucu ="+sonucMod);
            Console.ReadLine();



            



        }
    }
}
