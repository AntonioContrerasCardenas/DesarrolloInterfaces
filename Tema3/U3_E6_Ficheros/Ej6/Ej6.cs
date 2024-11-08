using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E6_Ficheros.Ej6
{
    public class Ej6
    {
        public Ej6() {

            string pathFichero = "../../../Ej6/fichero/enteros.txt";

            try
            {
                string[] texto = File.ReadAllLines(pathFichero);
                int[] numeros = texto.SelectMany(linea => linea.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)).Select(t => int.Parse(t)).ToArray();

                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }

                int numerosLeidos = numeros.Length;
                int suma = numeros.Sum(t => t);


                Console.WriteLine("Números leídos: " + string.Join(", ", numeros));
                Console.WriteLine("Cantidad de números: " + numerosLeidos);
                Console.WriteLine("Suma de los números: " + suma);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
