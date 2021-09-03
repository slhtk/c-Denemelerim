using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi =0;
            //Random rnd = new Random();
            //sayi = rnd.Next(1, 3);
            //Console.WriteLine(sayi);
            //Console.ReadLine();


            string[] Isimler = new[] { "ali", "veli", "ahmet" };
            Random rnd = new Random();
            sayi = rnd.Next(1,3);
            Console.WriteLine(Isimler[sayi]);
            Console.ReadLine();
        }

        
    }
}
