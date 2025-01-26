﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Dangl.Calculator;
using PropertyChanged;

namespace Calculadora.MVVM.ModelsView
{
    [AddINotifyPropertyChangedInterface]
    public class CalculadoraViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand AddOperation => new Command((number) => { Formula += number; });

        public ICommand ResetCommand => new Command(() => { Result = "0"; Formula = ""; });

        public ICommand DeleteLastCommand => new Command(() => {
            if (Formula.Length < 0)
                return;

            Formula = Formula.Substring(0, Formula.Length - 1);
        }); 

            public ICommand CalculateResultOperation => new Command(() => {
                if (Formula.Length < 0)
                    return;

                Result = Calculator.Calculate(Formula).Result.ToString();
            });
    }
}
