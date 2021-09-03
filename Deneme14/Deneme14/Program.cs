using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region iç içe for döngüsü
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion
        }
    }
}
