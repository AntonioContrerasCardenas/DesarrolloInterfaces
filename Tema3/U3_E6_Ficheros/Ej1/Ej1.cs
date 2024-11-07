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

            File.WriteAllText(f2, contenidoArchivo1);

            Console.WriteLine("Arhivos copiados correctamente");
        }
    }
}
