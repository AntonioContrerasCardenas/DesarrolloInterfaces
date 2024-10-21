using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej2
{
    public class Television : Electrodomestico
    {
        public const double RESOLUCION = 20;
        public const Boolean SINTONIZADOR = false;

        public Television() : base()
        {
        }

        public Television(double precio_base, int peso) : base(precio_base, peso)
        {
        }

        public Television(double resolucion, Boolean sintonizador, double precio_base, Colores color, Consumo consumo, int peso) : base(precio_base, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizador;
        }

        public double resolucion { get; set; } = RESOLUCION;
        public Boolean sintonizadorTDT { get; set; } = SINTONIZADOR;

        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (this.resolucion > 40) precioFinal += (precioFinal * 0.3) ;
            if (this.sintonizadorTDT) precioFinal += 50;

            return precioFinal;
        }



    }
}
