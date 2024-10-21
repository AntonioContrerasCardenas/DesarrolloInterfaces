using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E8_Herencia_e_intefaz_Archivo.Ej1
{
    public class Tecnico : Operario
    {
        public Tecnico(string nombre) : base(nombre)
        {
        }

        public override string ToString()
        {
            return base.ToString()+" -> Tecnico";
        }
    }
}
