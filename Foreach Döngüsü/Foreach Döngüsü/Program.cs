using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Isimler = new[] { "ali", "veli", "ahmet" };
            foreach (string item in Isimler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
           
        }

    }
}
