using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej2
{
    public class Lavadora : Electrodomestico
    {
        public const int CARGA = 5;


        public int Carga { get; set; } = CARGA;


        public Lavadora(double precio_base, int peso) : base(precio_base, peso)
        {
        }


        public Lavadora() : base() 
        {
        }

        public Lavadora(int carga, double precio_base, Colores color, Consumo consumo, int peso) : base(precio_base, color, consumo, peso)
        {
            this.Carga = carga;
        }

        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (this.Carga > 30) precioFinal += 50;
            return precioFinal;
        }
    }
}
