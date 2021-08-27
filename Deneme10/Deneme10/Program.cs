using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı Kodunuzu Giriniz: ");
            string kullancıKodu = Console.ReadLine();
            kullancıKodu = kullancıKodu.ToUpper();
            if (kullancıKodu=="AA" || kullancıKodu=="BB" || kullancıKodu=="CC")
            {
                Console.WriteLine("Admin yetkisine sahipsiniz.");
            }
            else if (kullancıKodu=="DD")
            {
                Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz");
            }
            else if (kullancıKodu=="EE" || kullancıKodu=="FF" || kullancıKodu=="GG")
            {
                Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz");
            }
            else
            {
                Console.WriteLine("Yetkiniz yok kullanıcı adınızı kontrol ediniz");
            }
            Console.ReadLine();
        }
    }
}
