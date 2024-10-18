using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_Clases
{
    public class Dado
    {
        public int Valor { get; set; }

        public Dado()
        {
            Valor = 0;
        }

        public void Tirar()
        {
            Random random = new Random();
            Valor = random.Next(6) + 1;
        }

        public void Imprimir()
        {
            Console.WriteLine($"El valor del dado es: {Valor}");
        }
    }
}
