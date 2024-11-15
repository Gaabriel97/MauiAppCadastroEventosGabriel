using MauiAppCadastroEventosGabriel.Models;

namespace MauiAppCadastroEventosGabriel.Views
{
    public partial class EventoCadastro : ContentPage
    {
        public EventoCadastro()
        {
            InitializeComponent();
            BindingContext = App.EventoAtual;

            dtpck_DataInicio.MinimumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
            dtpck_DataInicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_DataTermino.MinimumDate = dtpck_DataInicio.Date.AddDays(1);
            dtpck_DataTermino.MaximumDate = dtpck_DataInicio.Date.AddMonths(6);
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventoCadastrado());
        }
    }
}
