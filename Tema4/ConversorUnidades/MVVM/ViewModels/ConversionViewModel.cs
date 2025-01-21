using System.Collections.ObjectModel;
using UnitsNet;

namespace ConversorUnidades.MVVM.ViewModels
{
    public class ConversionViewModel
    {

        public string QuantityName { get; set; }
        public ObservableCollection<string> FromMedidas { get; set; }
        public ObservableCollection<string> ToMedidas { get; set; }

        public string SelectedMedidasTo { get; set; }
        public string SelectedMedidasFrom { get; set; }
        public double ValorAConvertir { get; set; }
        public double Resultado { get; set; }

        public ConversionViewModel() { }

        public ConversionViewModel(String conversionType)
        {
            this.QuantityName = conversionType;
            this.FromMedidas = CargaMedidas();
            this.ToMedidas = CargaMedidas();
        }

        public void CalculateResult()
        {
            Resultado = UnitConverter.ConvertByName(ValorAConvertir, QuantityName, SelectedMedidasFrom, SelectedMedidasTo);
        }

        private ObservableCollection<string> CargaMedidas()
        {
            var types = Quantity.Infos.FirstOrDefault(x => x.Name == QuantityName).UnitInfos.Select(u => u.Name).ToList();
            return new ObservableCollection<string>(types);
        }
    }
}
