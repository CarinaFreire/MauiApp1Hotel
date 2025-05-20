namespace MauiApp1Hotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent(); // <-- ESSA LINHA FAZ O XAML APARECER
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
    
