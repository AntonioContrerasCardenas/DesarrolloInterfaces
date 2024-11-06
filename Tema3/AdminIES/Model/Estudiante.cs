using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.Model
{
    class Estudiante
    {
        public int ID { get; set; }
        public string NombreEstudiante { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Ciclo { get; set; }
        public string Email { get; set; }
        public string FotoEstudiante { get; set; }

        public Estudiante(int iD, string nombreEstudiante, string primerApellido, string segundoApellido, int ciclo, string email, string fotoEstudiante)
        {
            ID = iD;
            NombreEstudiante = nombreEstudiante;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Ciclo = ciclo;
            Email = email;
            FotoEstudiante = fotoEstudiante;
        }

        public Estudiante(string nombreEstudiante, string primerApellido, string segundoApellido, int ciclo, string email, string fotoEstudiante) : this(nombreEstudiante, primerApellido, segundoApellido, ciclo, email)
        {
            FotoEstudiante = fotoEstudiante;
        }

        public Estudiante(string nombreEstudiante, string primerApellido, string segundoApellido, int ciclo, string email)
        {
            NombreEstudiante = nombreEstudiante;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Ciclo = ciclo;
            Email = email;
        }

        public Estudiante()
        {
        }
    }
}
