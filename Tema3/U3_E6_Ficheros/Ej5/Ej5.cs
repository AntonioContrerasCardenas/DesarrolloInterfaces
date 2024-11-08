using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E6_Ficheros.Ej5
{
    internal class Ej5
    {
        public Ej5()
        {
            string pathPrimerFichero = "../../../Ej5/ficheros/1.txt";
            string pathSegundoFichero = "../../../Ej5/ficheros/2.txt";
            string pathDestino = "../../../Ej5/ficheros/union.txt";

            try
            {
                string[] lineasPrimerFichero = File.ReadAllLines(pathPrimerFichero);
                string[] lineasSegundoFichero = File.ReadAllLines(pathSegundoFichero);


                using (StreamWriter sw = new StreamWriter(pathDestino))
                {

                    int maxLineas = Math.Max(lineasPrimerFichero.Length, lineasSegundoFichero.Length);

                    for (int i = 0; i < maxLineas; i++)
                    {
                        if (i < lineasPrimerFichero.Length)
                            sw.WriteLine(lineasPrimerFichero[i]);

                        if (i < lineasSegundoFichero.Length)
                            sw.WriteLine(lineasSegundoFichero[i]);
                    }
                }


                Console.WriteLine("Union en el archivo union.txt completa");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
