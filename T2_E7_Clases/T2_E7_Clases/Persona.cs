using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_Clases
{
    public class Persona
    {
        private string Nombre;
        private int Edad;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        

        public virtual void Imprimir()
        {
            Console.WriteLine($"Persona con nombre: {nombre} y edad: {edad}");
        }
    }
}
