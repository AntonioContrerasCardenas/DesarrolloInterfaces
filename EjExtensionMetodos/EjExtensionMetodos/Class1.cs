using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExtensionMetodos
{
    abstract class Class1
    {
        public static int Valor { get; set; } = 0;
        public int Valor2 { get; set; } = 0;

        public Class1(int valor2)
        {
            Valor2 = valor2;
        }

        public abstract void Hola();
    }
}
