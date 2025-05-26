using Microsoft.Maui.Controls;
using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rotas para navegação via Shell
            Routing.RegisterRoute("resultado", typeof(ResultadoPage));
            Routing.RegisterRoute("SobrePage", typeof(SobrePage));
            Routing.RegisterRoute("ContratacaoHospedagem", typeof(ContratacaoHospedagem));
        }
    }
}
