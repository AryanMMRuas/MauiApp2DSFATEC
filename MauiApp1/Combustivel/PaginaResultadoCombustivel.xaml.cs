using System;
using Microsoft.Maui.Controls;

namespace MauiApp1.Combustivel
{
    public partial class PaginaResultadoCombustivel : ContentPage
    {
        public PaginaResultadoCombustivel(string melhorOpcao)
        {
            InitializeComponent();

            gasolina.IsVisible = false;
            etanol.IsVisible = false;

            lblResultado.Text = $"A melhor opção é: {melhorOpcao}";           

            if (melhorOpcao == "Gasolina")
                gasolina.IsVisible = true;

            if (melhorOpcao == "Etanol")
                etanol.IsVisible = true;
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
