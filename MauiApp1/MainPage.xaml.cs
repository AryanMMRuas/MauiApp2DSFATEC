using MauiApp1.Combustivel;
using MauiApp1.ExemploPadrao;
using MauiApp1.Saudacao;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BotaoSaudacao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaSaudacao());
        }

        private async void BotaoExemploPadrao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaExemploPadrao());
        }

        private async void BotaoCompararCombustivel_Clicked(object sender, EventArgs e)
        {
            // Obtendo o preço da gasolina
            string gasolinaInput = await DisplayPromptAsync("Preço da Gasolina", "Digite o preço da gasolina:",
                                                            keyboard: Keyboard.Numeric);

            if (!decimal.TryParse(gasolinaInput, out decimal precoGasolina) || precoGasolina <= 0)
            {
                await DisplayAlert("Erro", "Digite um valor válido para a gasolina.", "OK");
                return;
            }

            // Obtendo o preço do etanol
            string etanolInput = await DisplayPromptAsync("Preço do Etanol", "Digite o preço do etanol:",
                                                          keyboard: Keyboard.Numeric);
            if (!decimal.TryParse(etanolInput, out decimal precoEtanol) || precoEtanol <= 0)
            {
                await DisplayAlert("Erro", "Digite um valor válido para o etanol.", "OK");
                return;
            }

            // Calculando a relação preço do etanol/gasolina
            bool etanolMaisVantajoso = (precoEtanol / precoGasolina) < 0.7m;
            string melhorOpcao = etanolMaisVantajoso ? "Etanol" : "Gasolina";

            // Navegando para a página de resultado
            await Navigation.PushAsync(new PaginaResultadoCombustivel(melhorOpcao));
        }

        private async void BotaoCodigopage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CodigoPage());
        }
    }

}
