namespace MauiApp1Hotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}
    private async void Button_Clicar(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ContratacaoHospedagem());
	}
}