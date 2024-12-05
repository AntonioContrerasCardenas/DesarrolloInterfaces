using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E6_Ficheros.Ej1
{
    public class Ej1
    {

        public Ej1(string f1, string f2) { 
            
            string contenidoArchivo1 = File.ReadAllText(f1);

            File.AppendAllText(f2, contenidoArchivo1);
            //File.WriteAllText(f2, contenidoArchivo1);

            Console.WriteLine("Arhivos copiados correctamente");

            
            /*try
            {
                File.Copy(f1, f2, false); // Copia el contenido directamente
                Console.WriteLine($"Fichero copiado de {f1} a {f2}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }*/
        }
    }
}
