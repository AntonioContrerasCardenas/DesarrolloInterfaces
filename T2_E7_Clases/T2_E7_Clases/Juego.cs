using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_Clases
{
    public class Juego
    {
        public List<Dado> Dados { get; set; }

        public Juego(List<Dado> dados)
        {
            Dados = dados;
        }

        public void Jugar()
        {
            int firstDato = Dados.First().Valor;
            Boolean gana = true;
            Dados.ForEach(d =>  {
                d.Tirar();
                d.Imprimir();
                if(d.Valor != firstDato) gana = false;
                } );

            Console.WriteLine(gana ? "Gana" : "Pierde");

        }
    }
}
