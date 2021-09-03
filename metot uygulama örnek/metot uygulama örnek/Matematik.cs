using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_uygulama_örnek
{
    public class Matematik
    {
        // topla metodu
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public decimal cıkartmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;            
        }
        public void menuHazırla()
        {
            Console.Clear();
            Console.WriteLine("*** Menü ***");
            Console.WriteLine("1- Topla:");
            Console.WriteLine("2- Çıkart:");
            Console.WriteLine("3- Böl:");
            Console.WriteLine("4- Çarp:");
            Console.Write("Lütfen deger seçiniz:");
        }
        public void sonucEkranaYaz(decimal kullanicisayi1, decimal kullanicisayi2,decimal sonuc,string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", kullanicisayi1, operators, kullanicisayi2, sonuc);
        }
    }
}
