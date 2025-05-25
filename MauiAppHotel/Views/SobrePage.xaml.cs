using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class SobrePage : ContentPage
    {
        public SobrePage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Navega de volta para a página principal (calculadora)
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}