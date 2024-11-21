using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E9_Serializacion_XML.Clases
{
    public class Cliente
    {
        public string DNI{ get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public int NumCuentaCorriente { get; set; }

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
