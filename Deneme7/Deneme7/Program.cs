using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciKodu = Console.ReadLine();
            kullaniciKodu = kullaniciKodu.ToUpper(); // girilen değerler küçük harf olsa bile harfleri büyütüp üzerine yazar

        // ToLower = harfleri küçültür.yukarıda ToLower kullansaydık girilen değer büyük olsaydı küçük harfe çevirip üzerine yazıcaktı. 

            //SİSTEME GİRİŞİNE İZİN VERİLEN KULLANICI ADLARI
            if (kullaniciKodu=="ABC" || kullaniciKodu=="123" || kullaniciKodu=="236" || kullaniciKodu=="CMK")
            {
                Console.Write("Kullanıcı girişi başarılı.");
            }
            // YASAKLI KULLANICILAR 
            else if (kullaniciKodu=="HHH" || kullaniciKodu=="BBB" || kullaniciKodu=="MMM")
            {
                Console.Write("Hesabınız kilitlenmiştir.");
            }
            else
            {
                Console.Write("Hatalı kullanıcı kodu.");
            }
            Console.ReadLine();
        }
    }
}
