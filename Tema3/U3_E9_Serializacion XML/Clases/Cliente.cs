using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E9_Serializacion_XML.Clases
{
    public class Cliente
    {
        private string DNI{ get; set; }
        private string Nombre { get; set; }
        private string Direccion { get; set; }
        private int Edad { get; set; }
        private int Telefono { get; set; }
        private int NumCuentaCorriente { get; set; }

        public Cliente() { }

        public Cliente(string dNI, string nombre, string direccion, int edad, int telefono, int numCuentaCorriente)
        {
            DNI = dNI;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            NumCuentaCorriente = numCuentaCorriente;
        }
    }
}
