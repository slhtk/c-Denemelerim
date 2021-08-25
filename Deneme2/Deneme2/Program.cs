using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "True";
            bool a1 = bool.Parse(metin1); 
            bool a2 = Convert.ToBoolean(metin1);
            
            int s1 = 100;
            byte byteDegisken = (byte) s1; // int değeri daha küçük bir değer alan byte ' a dönüştürürken (byte) yazılır.
            float floatDeegisken = s1;

            byte b1 = 10;
            decimal decimalDegisken = b1; //byte dan daha büyük değer aldığı için eşittirden sonra (decimal) yazılmadı .



        }
    }
}
