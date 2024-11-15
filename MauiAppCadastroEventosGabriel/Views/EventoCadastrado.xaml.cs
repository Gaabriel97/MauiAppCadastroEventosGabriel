using MauiAppCadastroEventosGabriel.Models;

namespace MauiAppCadastroEventosGabriel.Views
{
    public partial class EventoCadastrado : ContentPage
    {
        public EventoCadastrado()
        {
            InitializeComponent();
            BindingContext = App.EventoAtual;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
