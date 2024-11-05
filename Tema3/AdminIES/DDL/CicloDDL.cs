using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DDL
{
    class CicloDDL
    {
        Conexion conexion;

        public CicloDDL()
        {
            this.conexion = new Conexion();
        }

        public bool Agregar(string nombreCiclo)
        {
            return this.conexion.EjecutarComandoSinRetornarDatos($"Insert into Ciclo(nombre) values ('{nombreCiclo}')");
        }

        public DataSet MostrarCiclos()
        {
            SqlCommand sentencia = new SqlCommand("Select * from ciclo");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool Eliminar(string idCiclo) {
            return this.conexion.EjecutarComandoSinRetornarDatos($"Delete from Ciclo where id = {idCiclo}");
        }

        public bool Actualizar(string idCiclo, string nombreCiclo) {
            return this.conexion.EjecutarComandoSinRetornarDatos($"Update Ciclo Set nombre = '{nombreCiclo}' Where id = {idCiclo}");
        }
    }
}
