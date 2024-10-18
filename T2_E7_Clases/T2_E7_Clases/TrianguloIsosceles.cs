using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_Clases
{
    public class TrianguloIsosceles
    {
        public int LongitudLadosIguales { get; set; }
        public int LongitudLadoDiferente { get; set; }
        public int Altura { get; set; }

        public TrianguloIsosceles(int longitudLadosIguales, int longitudLadoDiferente, int altura)
        {
            LongitudLadosIguales = longitudLadosIguales;
            LongitudLadoDiferente = longitudLadoDiferente;
            Altura = altura;
        }

        public int Perimetro()
        {
            return (LongitudLadosIguales * 2) + LongitudLadoDiferente;
        }

        public int Area()
        {
            return (LongitudLadoDiferente * Altura) / 2;
        }
    }
}
