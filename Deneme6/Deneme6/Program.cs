using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme6
{
    class Program
    {

        static void Main(string[] args)


        {
            Console.Write("Kullanıcı adını giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifrenizi Giriniz : ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "Salih" && sifre == "12345")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız Şifrenizi veya Kullanıcı Adınızı Kontrol Ediniz");
            }
            Console.ReadLine();


        }
    }
}
