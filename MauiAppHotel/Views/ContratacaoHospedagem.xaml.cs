using System;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    Dictionary<string, double> precosSuites = new Dictionary<string, double>
    {
        { "Suíte Simples", 150 },
        { "Suíte Luxo", 250 },
        { "Suíte Master", 350 }
    };

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        // Preenche o Picker com as opções
        foreach (var suite in precosSuites.Keys)
        {
            pck_quarto.Items.Add(suite);
        }
    }

    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        int adultos = (int)stp_adultos.Value;
        int criancas = (int)stp_criancas.Value;
        string suiteEscolhida = pck_quarto.SelectedItem as string;

        if (suiteEscolhida == null)
        {
            await DisplayAlert("Erro", "Selecione uma suíte.", "OK");
            return;
        }

        DateTime checkin = dtpck_checkin.Date;
        DateTime checkout = dtpck_checkout.Date;
        int totalDias = (checkout - checkin).Days;

        if (totalDias <= 0)
        {
            await DisplayAlert("Erro", "O check-out deve ser após o check-in.", "OK");
            return;
        }

        double precoPorDia = precosSuites[suiteEscolhida];
        double totalAdultos = adultos * precoPorDia * totalDias;
        double totalCriancas = criancas * (precoPorDia * 0.5) * totalDias;
        double total = totalAdultos + totalCriancas;

        // Envia para a página de resultado
        await Shell.Current.GoToAsync($"resultado?" +
            $"valor={total:0.00}&" +
            $"dias={totalDias}&" +
            $"precoDiaria={precoPorDia:0.00}&" +
            $"valorCriancas={totalCriancas:0.00}");
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SobrePage");
    }
}