using AdminIES.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DDL
{
    class EstudianteDDL
    {
        Conexion conexion;

        public EstudianteDDL()
        {
            this.conexion = new Conexion();
        }

        public DataSet getCiclos()
        {
            SqlCommand sentencia = new SqlCommand("Select * from Ciclo");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet getEstudiantes()
        {
            SqlCommand sentencia = new SqlCommand("Select * from Estudiante");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool Agregar(Estudiante estudiante)
        {
            return this.conexion.EjecutarComandoSinRetornarDatos($"Insert into Estudiante(nombre, primerapellido, segundoapellido, email, foto) " +
                $"values ('{estudiante.NombreEstudiante}','{estudiante.PrimerApellido}','{estudiante.SegundoApellido}','{estudiante.Email}','{estudiante.FotoEstudiante}')");
        }


    }
}
