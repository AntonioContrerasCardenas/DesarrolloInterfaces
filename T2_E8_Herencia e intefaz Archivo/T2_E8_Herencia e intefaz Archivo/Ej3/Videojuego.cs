using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej3
{
    public class Videojuego : Entregable
    {
        public String Titulo { get; set; } = "";
        public int HorasEstimadas { get; set; } = 10;
        public String Genero { get; set; }
        public Boolean Entregado { get; set; } = false;
        public String Compania { get; set; } = "";

        public Videojuego()
        {
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compania) : this(titulo, horasEstimadas)
        {
            Genero = genero;
            Compania = compania;
        }

        public override string ToString()
        {
            return $"VIDEOJUEGO: Título: {Titulo}, Horas estimadas: {HorasEstimadas}, Género: {Genero}, Entregado: {Entregado}, Compañia: {Compania}"; 
        }

        public void entregar()
        {
            this.Entregado = true;
        }

        public void devolver()
        {
            this.Entregado = false;
        }

        public bool isEntregado()
        {
            return this.Entregado;
        }
    }
}
