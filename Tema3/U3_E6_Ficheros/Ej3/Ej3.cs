using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E6_Ficheros.Ej3
{
    public class Ej3
    {
        public Ej3()
        {
            Console.WriteLine("¿Que fichero deseas duplicar?");
            string ficheroOriginal = Console.ReadLine();

            Console.WriteLine("¿Que nombre le quieres dar al nuevo archivo?");
            string nombreFicheroDuplicar = Console.ReadLine();

            string pathFicheros = "../../../ficheros/";

            try
            {
                File.Copy($"{pathFicheros}/{ficheroOriginal}", $"{pathFicheros}/{nombreFicheroDuplicar}", true);
                Console.WriteLine("Fichero duplicado con exito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al duplicar el fichero");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
