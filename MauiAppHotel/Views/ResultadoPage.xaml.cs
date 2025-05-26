using System;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace MauiAppHotel.Views
{
    [QueryProperty(nameof(ValorCriancas), "valorCriancas")]
    [QueryProperty(nameof(Valor), "valor")]
    [QueryProperty(nameof(Dias), "dias")]
    [QueryProperty(nameof(PrecoDiaria), "precoDiaria")]
    public partial class ResultadoPage : ContentPage
    {
        public string ValorCriancas
        {
            set => lbl_criancas.Text = $"Valor total das crianças: R$ {value}";
        }
        public string Valor
        {
            set => lbl_valor.Text = $"Valor total: R$ {value}";
        }

        public string Dias
        {
            set => lbl_dias.Text = $"Dias de estadia: {value}";
        }

        public string PrecoDiaria
        {
            set => lbl_diaria.Text = $"Valor da diária por adulto: R$ {value}";

        }

        public ResultadoPage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ContratacaoHospedagem");
        }
    }
}
