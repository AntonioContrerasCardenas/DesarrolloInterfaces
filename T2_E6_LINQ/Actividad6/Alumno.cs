using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad6
{
    public class Alumno
    {
        static void Main(string[] args)
        {
        }

        public string Nombre { get; set; }
        public int Nota { get; set; }

        public static List<string> getNombres(List<Alumno> alumnos)
        {
            return alumnos.Select(a => a.Nombre).ToList();
            throw new NotImplementedException();
        }

        public static Alumno getListadoNota(List<Alumno> alumnos, int nota)
        {
            return alumnos.First(a => a.Nota == nota);
            throw new NotImplementedException();
        }

        public static Alumno getPrimerAlumno(List<Alumno> alumnos)
        {
            return alumnos.First();
            throw new NotImplementedException();
        }

        public static Alumno getUltimoAlumno(List<Alumno> alumnos)
        {
            return alumnos.Last();
            throw new NotImplementedException();
        }

        public static int getSumaNota(List<Alumno> alumnos)
        {
            return alumnos.Sum(a => a.Nota);
            throw new NotImplementedException();
        }

        public static int getNotaMaxima(List<Alumno> alumnos)
        {
            return alumnos.Max(a => a.Nota);
            throw new NotImplementedException();
        }

        public static int getNotaMinima(List<Alumno> alumnos)
        {
            return alumnos.Min(a => a.Nota);
            throw new NotImplementedException();
        }

        public static int getNotaPorNombre(List<Alumno> alumnos, string v)
        {
            var alumno = alumnos.FirstOrDefault(a => a.Nombre.Equals(v));
            //return alumno.Nota;
            return alumno != null ? alumno.Nota : 1;
            throw new NotImplementedException();
        }

        public static double getNotaMedia(List<Alumno> alumnos)
        {
            return Math.Round(alumnos.Average(a => a.Nota) ,2);
            throw new NotImplementedException();
        }
    }
}
