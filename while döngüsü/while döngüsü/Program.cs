using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int tahminAdet = 1; 
            Random rnd = new Random();
            sayi = rnd.Next(1, 10);

            while (true)
            {
                Console.Write("{0}. deneme-Sistemin ürettiği sayıyı tahmin ediniz : ",tahminAdet);
                string rndkullanıcıGelensayi = Console.ReadLine();
              //  int rndkullanıcıGelensayi = int.Parse(rndkullanıcıGelensayi);

                 if (int.Parse(rndkullanıcıGelensayi)==sayi)
              //  if(rndkullanıcıGelensayi == sayi)
                {
                    tahminAdet++;
                    Console.WriteLine("{0}.denemenizde doğru bildiniz",tahminAdet);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("{0}. denemeniz , Tahmin edemediniz lütfen tekrar deneyin!", tahminAdet);
                    tahminAdet++;
                }
                Console.ReadLine();

            }

        }
    }
}
