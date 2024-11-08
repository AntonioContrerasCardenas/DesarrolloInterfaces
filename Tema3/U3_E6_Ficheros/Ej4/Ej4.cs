using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_E6_Ficheros.Ej4
{
    public class Ej4
    {
        public Ej4()
        {
            string pathNotasTxt = "../../../Ej4/ficheros/notas.txt";
            string pathResultadoTxt = "../../../Ej4/ficheros/resultado.txt";

            try
            {
                string[] lineas = File.ReadAllLines(pathNotasTxt);

                double sumatorioMates = 0;
                double maxNotaInfor = 0;
                string alumnoMejorNota = "";

                foreach (string line in lineas)
                {
                    string[] strings = line.Split(" ");
                    string nombre = strings[0];
                    string notaMates = strings[1];
                    string notaInfo = strings[2];

                    double notaInfoD = double.Parse(notaInfo);
                    sumatorioMates += double.Parse(notaMates);

                    if(notaInfoD > maxNotaInfor)
                    {
                        maxNotaInfor = notaInfoD;
                        alumnoMejorNota = nombre;
                    }
                    
                }

                double mediaMates = lineas.Length > 0 ? (sumatorioMates/lineas.Length) : 0;

                using(StreamWriter sw = new StreamWriter(pathResultadoTxt))
                {
                    sw.WriteLine("Mejor alumno: " + alumnoMejorNota);
                    sw.WriteLine("Media matematicas: " + mediaMates);
                    sw.WriteLine("Mejor nota informatica: " + maxNotaInfor);

                }

                Console.WriteLine("Se ha completado el programa!!!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
