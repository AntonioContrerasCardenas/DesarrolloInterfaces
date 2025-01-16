﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5IMC2.MVVM.Models
{
    public class IMCModel
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Resultado => Peso / (Altura * Altura);

        public string Clasificacion //Esto es similar a un metodo que devuelva la clasificacion de imc pero en este caso es una propiedad
        {
            get
            {
                if (Resultado <= 16) return "Delgadez Severa";
                if (Resultado <= 17) return "Delgadez Moderada";
                if (Resultado <= 18.5) return "Delgadez Ligera";
                if (Resultado <= 25) return "Normal";
                if (Resultado <= 30) return "Sobrepeso";
                if (Resultado <= 35) return "Obesidad Clase I";
                if (Resultado <= 40) return "Obesidad Clase II";
                return "Obesidad Clase III";
            }
        }

    }
}
