using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P5IMC2.MVVM.Models;

namespace P5IMC2.MVVM.ViewModels
{
    public class IMCViewModel
    {
        public IMCModel Imcmodel{ get; set; }

        public IMCViewModel()
        {
            Imcmodel = new IMCModel
            {
                Altura = 180,
                Peso = 73,
            };
        }
    }
}
