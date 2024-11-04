using System;
using System.Collections.Generic;
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
    }
}
