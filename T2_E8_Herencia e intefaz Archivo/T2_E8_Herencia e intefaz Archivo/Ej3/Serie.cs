using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej3
{
    public class Serie
    {
        public const int NUMERO_TEMPORADAS= 3;
        public const Boolean ENTREGADO = false;

        public String Titulo { get; set; } 
        public int NumeroTemporadas { get; set; } = NUMERO_TEMPORADAS;
        public Boolean Entregado { get; set; } = ENTREGADO;
        public String Creador { get; set; } 

        public String Genero { get; set; }

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            Titulo = titulo;
            Creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string creador, string genero)
        {
            Titulo = titulo;
            NumeroTemporadas = numeroTemporadas;
            Creador = creador;
            Genero = genero;
        }

        public override string ToString()
        {
            return "Hola desde Serie";
        }
    }
}
