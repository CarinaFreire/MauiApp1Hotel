namespace MauiApp1Hotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{

    App PropriedadesdoApp;
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesdoApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesdoApp.lista_quartos;

        dtpck_chekin.MinimumDate = DateTime.Now;
        dtpck_chekin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_chekin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_chekin.Date.AddMonths(6);

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());

        } catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private void dtpck_chehin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_chekin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_chekin.AddDays(1);
        dtpck_chekin.MaximumDate = data_selecionada_chekin.AddMonths(6);
    }   
}