
using MauiApp1Hotel.Models;

namespace MauiApp1Hotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Família Simples",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.00
            },
            new Quarto()
            {
                Descricao = "Suíte Família Luxo",
                ValorDiariaAdulto = 180.0,
                ValorDiariaCrianca = 80.00
            },
        new Quarto()
        {
                Descricao = "Suíte Família Super Luxo",
                ValorDiariaAdulto = 200.0,
                ValorDiariaCrianca = 105.00
            }
    };
    public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}
