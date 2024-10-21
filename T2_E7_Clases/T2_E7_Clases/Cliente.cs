using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_Clases
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public double CantidadAhorrada { get; set; }

        public Cliente(string dNI, string nombre, double cantidadAhorrada)
        {
            DNI = dNI;
            Nombre = nombre;
            CantidadAhorrada = cantidadAhorrada;
        }

        public void Ingresar(double cantidad)
        {
            CantidadAhorrada += cantidad;
            Console.WriteLine($"El cliente {Nombre} ha ingresado {cantidad} euros.");
        }

        public void Extraer(double cantidadExtraer)
        {
            if(CantidadAhorrada < cantidadExtraer)
            {
                CantidadAhorrada -= cantidadExtraer;
                Console.WriteLine($"El cliente {Nombre} ha retirado {cantidadExtraer} euros.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Consultar()
        {
            Console.WriteLine($"El cliente {Nombre} tiene ahorrado {CantidadAhorrada} euros.");
        }


    }
}
