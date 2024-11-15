using MauiAppCadastroEventosGabriel.Models;

namespace MauiAppCadastroEventosGabriel
{
    public partial class App : Application
    {
        public static Evento EventoAtual { get; set; } = new Evento();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.EventoCadastro());
        }
    }
}
