using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 1; i <=100; i++)
            {
                if(i%2==0)
                {
                    n += i;                    
                }
            }
            Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı: " + n);
            Console.ReadLine();
        }        
    }
}
