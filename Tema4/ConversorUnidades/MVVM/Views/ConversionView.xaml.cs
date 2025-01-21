using ConversorUnidades.MVVM.ViewModels;

namespace ConversorUnidades.MVVM.Views;

public partial class ConversionView : ContentPage
{
    public string conversion;
    public ConversionViewModel conversionViewModel { get; set; }

    public ConversionView()
    {
        InitializeComponent();
    }

    public ConversionView(string conversionType)
    {
        InitializeComponent();
        this.conversion = conversionType;
        conversionViewModel = new ConversionViewModel(conversionType);
        BindingContext = conversionViewModel;

        PickerFrom.SelectedIndex = 0;
        PickerTo.SelectedIndex = 0;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        conversionViewModel.CalculateResult();
    }
}