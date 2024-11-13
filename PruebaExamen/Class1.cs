using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen
{
    static class Class1
    {
        public static void Muestra(this int desde, int hasta)
        {
            for (int i = desde; i <= hasta; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
