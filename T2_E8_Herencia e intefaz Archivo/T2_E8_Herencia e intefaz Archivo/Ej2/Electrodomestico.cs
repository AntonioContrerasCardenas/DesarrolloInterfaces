using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej2
{
    public abstract class Electrodomestico
    {
        public const double Precio_Base = 100;
        public const Colores Color = Colores.blanco;
        public const Consumo ConsumoI = Consumo.F;
        public const int Peso = 5;

        protected double precio_base { get; set; } = Precio_Base;
        protected Colores color { get; set; } = Color;
        protected Consumo consumo { get; set; } = ConsumoI;
        protected int peso { get; set; } = Peso;

        public Electrodomestico()
        {
        }

        public Electrodomestico(double precio_base, int peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
        }

        public Electrodomestico(double precio_base, Colores color, Consumo consumo, int peso)
        {
            this.precio_base = precio_base;
            this.color = color;
            this.consumo = consumo;
            this.peso = peso;
            ComprobarColor(color);
            ComprobarConsumoEnergia(consumo);
            //PrecioFinal();
        }

        public void ComprobarConsumoEnergia(Consumo letra)
        {
            if (!Enum.IsDefined(typeof(Consumo), letra)) this.consumo = ConsumoI;
        }

        public void ComprobarColor(Colores color)
        {
            if (!Enum.IsDefined(typeof(Colores), color)) this.color = Color;
        }

        public virtual double PrecioFinal()
        {
            double incremento = 0;
            switch (this.consumo)
            {
                case Consumo.A:
                    incremento += 100;
                    break;

                case Consumo.B:
                    incremento += 80;
                    break;

                case Consumo.C:
                    incremento += 60;
                    break;

                case Consumo.D:
                    incremento += 50;
                    break;

                case Consumo.E:
                    incremento += 30;
                    break;

                case Consumo.F:
                    incremento += 10;
                    break;

                default:
                    break;
            }

            switch (this.peso)
            {
                case <=19:
                    incremento += 10;
                    break;

                case <=49:
                    incremento += 50;
                    break;

                case <=79:
                    incremento += 80;
                    break;

                case >=80:
                    incremento += 100;
                    break;
            }

            return precio_base + incremento;
        }
    }
}
