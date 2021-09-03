using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İc_ice_for_döngüsü
{
    class Program
    {

        static void Main(string[] args)
        {

            for (int i = 0; i <= 9; i++)
            {

                for (int j = 1; j <= 9; j++)
                {
                    int carpımsonuc = i * j;
                    Console.Write("{0}*{1}={2}\t",i , j, carpımsonuc); // indexler  {0}- i yi yazar,{1}-j yi , {2}-carpımsonucu yazar . 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
