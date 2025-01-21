namespace ConversorUnidades.MVVM.Views;

public partial class PPrincPage : ContentPage
{
    public PPrincPage()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Grid grid)
        {
            string conversionType = grid.BindingContext as string;
            await Navigation.PushAsync(new ConversionView(conversionType));
        }


    }
}