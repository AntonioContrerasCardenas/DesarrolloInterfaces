using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T2_E7_Clases
{
    public class Empleado : Persona
    {
        private double Sueldo;

        public double sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }

        public Empleado(string nombre, int edad , double sueldo) : base(nombre, edad)
        {
            this.sueldo = sueldo;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Sueldo: {sueldo}");
        }
    }
}
