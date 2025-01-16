using P5IMC2.MVVM.ViewModels;

namespace P5IMC2.MVVM.Views;

public partial class IMCView : ContentPage
{
	public IMCView()
	{
		InitializeComponent();
		BindingContext = new IMCViewModel();
	}
}