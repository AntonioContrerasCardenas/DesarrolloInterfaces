using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionMetodos
{
    public static class IntExtensions
    {
        public static void ImprimirHasta(this int input, int desde)
        {
              for (int i = desde; i <= input; i++)
                {
                    Console.WriteLine(i);
                }
        }

        public static void ExtensionList<T> (this List<T> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
