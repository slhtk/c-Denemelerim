using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminiz Nedir ?");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınız Nedir ?");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Yaşadığınız şehri giriniz :");
            string sehir = Console.ReadLine();

            Console.WriteLine("Yaşınızı giriniz :");
            string yasStr = Console.ReadLine();
            int yasPArse = int.Parse(yasStr);
            int yasConvert = Convert.ToInt32(yasStr);

            Console.Clear();

            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim :" + soyisim);
            Console.WriteLine("Şehir : " + sehir);
            Console.WriteLine("Yaş :" + yasStr);

            Console.ReadLine();
        }
    }
}
