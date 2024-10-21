using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej2
{
    public class MainClass
    {
        public static void Main()
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            electrodomesticos[0] = new Lavadora(200,500);
            electrodomesticos[1] = new Television(700, 20);
            electrodomesticos[2] = new Lavadora();
            electrodomesticos[3] = new Television();
            electrodomesticos[4] = new Lavadora(31, 90, Colores.azul, Consumo.A, 90);
            electrodomesticos[5] = new Television(40, true, 80, Colores.blanco, Consumo.D,90);
            electrodomesticos[6] = new Lavadora(78, 20, Colores.negro, Consumo.F, 190);
            electrodomesticos[7] = new Television(10, false, 20, Colores.rojo, Consumo.C, 120);
            electrodomesticos[8] = new Lavadora();
            electrodomesticos[9] = new Television();

            double totalLavadoras = 0;
            double totalTelevisiones = 0;

            foreach (var electrodomestico in electrodomesticos)
            {
                double precio = electrodomestico.PrecioFinal();
                
                if(electrodomestico is Lavadora)
                {
                    totalLavadoras += precio;
                }

                if(electrodomestico is Television)
                {
                    totalTelevisiones += precio;
                }
            }

            Console.WriteLine($"El precio total de las valadoras es {totalLavadoras} euros");
            Console.WriteLine($"El precio total de las televisiones es {totalTelevisiones} euros");
            Console.WriteLine($"El precio total de los electrodomesticos es {totalTelevisiones + totalLavadoras} euros");
        }
    }
}
