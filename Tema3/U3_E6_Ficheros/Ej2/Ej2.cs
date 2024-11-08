using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E6_Ficheros.Ej2
{
    public class Ej2
    {

        public Ej2()
        {
            Console.WriteLine("Introduce el nombre del fichero");
            string fichero = Console.ReadLine();

            Console.WriteLine("Introduce la frase a buscar");
            string frase = Console.ReadLine();
            string rutaFichero = $"C:\\Users\\dam\\Desktop\\DesarrolloInterfaces\\Tema3\\U3_E6_Ficheros\\Ej2\\ficheros\\{fichero}";

            try
            {
                string[] lineas = File.ReadAllLines(rutaFichero);
                int c = 1;

                foreach(string linea in lineas)
                {

                    if (linea.Contains(frase))
                    {
                        Console.WriteLine($"Linea {c} : {linea}");
                    }

                    c++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
