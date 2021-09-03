using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonsuzdonguSayac = 0;
            for (; ; )
            {
                sonsuzdonguSayac++;
                if (sonsuzdonguSayac==6)
                {
                   // break; şart sağlandığında döngü sonlanır.
                    continue; //şart sağlanırsa şartı atlar dögü devam eder.
                }
                Console.WriteLine(sonsuzdonguSayac);
                Console.WriteLine("deneme");
                Console.ReadLine();
            }
        }
    }
}
