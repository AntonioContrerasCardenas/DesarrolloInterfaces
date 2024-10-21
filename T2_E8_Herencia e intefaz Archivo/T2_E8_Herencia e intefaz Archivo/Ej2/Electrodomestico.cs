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

        public double precio_base { get; set; } = Precio_Base;
        public Colores color { get; set; } = Color;
        public Consumo consumo { get; set; } = ConsumoI;
        public int peso { get; set; } = Peso;

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
            comprobarColor(color.ToString());
            comprobarConsumoEnergia(Char.Parse(color.ToString()));
            precioFinal();
        }

        public void comprobarConsumoEnergia(char letra)
        {
            if (!Enum.IsDefined(typeof(Consumo), letra)) this.consumo = ConsumoI;
        }

        public void comprobarColor(string color)
        {
            if (!Enum.IsDefined(typeof(Colores), color)) this.color = Color;
        }

        public virtual void precioFinal()
        {
            switch (this.consumo)
            {
                case Consumo.A:
                    precio_base += 100;
                    break;

                case Consumo.B:
                    precio_base += 80;
                    break;

                case Consumo.C:
                    precio_base += 60;
                    break;

                case Consumo.D:
                    precio_base += 50;
                    break;

                case Consumo.E:
                    precio_base += 30;
                    break;

                case Consumo.F:
                    precio_base += 10;
                    break;

                default:
                    break;
            }

            switch (this.peso)
            {
                case <=19:
                    precio_base += 10;
                    break;

                case <=49:
                    precio_base += 50;
                    break;

                case <=79:
                    precio_base += 80;
                    break;

                case >=80:
                    precio_base += 100;
                    break;

            }
        }
    }
}
