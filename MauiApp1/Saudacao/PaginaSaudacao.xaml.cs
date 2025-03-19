namespace MauiApp1.Saudacao;

public partial class PaginaSaudacao : ContentPage
{
	public PaginaSaudacao()
	{
		InitializeComponent();
	}

    private void btnSaudacao_Clicked(object sender, EventArgs e)
    {
        var nome = txtNome.Text;
        lblSaudacao.Text = $"Olá {nome}!";
    }

    private async void BotaoVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}