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
            DataSet toreturn = conexion.EjecutarSentencia(sentencia);
            return toreturn;
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

        internal bool Eliminar(int idEstudiante)
        {
            return this.conexion.EjecutarComandoSinRetornarDatos($"Delete from Estudiante where id = {idEstudiante}");
        }

        internal bool Modificar(Estudiante e)
        {
            string a = $"Update Estudiante set nombre = '{e.NombreEstudiante}',primerapellido = '{e.PrimerApellido}'" +
                $",segundoapellido = '{e.SegundoApellido}',email = '{e.Email}',foto = '{e.FotoEstudiante}' where id = {e.ID}";
            return this.conexion.EjecutarComandoSinRetornarDatos($"Update Estudiante set nombre = '{e.NombreEstudiante}',primerapellido = '{e.PrimerApellido}'" +
                $",segundoapellido = '{e.SegundoApellido}',email = '{e.Email}',foto = '{e.FotoEstudiante}' where id = {e.ID}");
        }
    }
}
