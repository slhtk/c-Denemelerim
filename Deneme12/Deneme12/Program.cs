using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme12
{
    class Program
    {
        static void Main(string[] args)
        {

            string kullanıcıdanGelenDeger = string.Empty;
            int kullanıcıdanGelenDegerInt = 0;
            int faktoriyelHesabı = 1;
            Console.WriteLine("Sayı Giriniz");
            kullanıcıdanGelenDeger = Console.ReadLine();
            kullanıcıdanGelenDegerInt = int.Parse(kullanıcıdanGelenDeger);

            for (int i = kullanıcıdanGelenDegerInt; i>1; i--)
            {

               // faktoriyelHesabı = faktoriyelHesabı * i;
                faktoriyelHesabı *= i;
            }
            Console.WriteLine("{0} degerinin faktoriyel sonucu: {1} ", kullanıcıdanGelenDeger, faktoriyelHesabı);
            // {0}. index 1. değeri {1} indexi ikinci değeri yazıyor.
            Console.ReadLine();
            
        }
    }
}
