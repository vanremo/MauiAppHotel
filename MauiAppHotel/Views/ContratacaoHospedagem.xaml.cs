using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        // Os "//" no começo forçam a navegação para 
        // o ShellContent de nível root com Route="SobrePage"
        await Shell.Current.GoToAsync("//SobrePage");
    }

}