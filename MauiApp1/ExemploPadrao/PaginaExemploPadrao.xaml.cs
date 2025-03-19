namespace MauiApp1.ExemploPadrao;

public partial class PaginaExemploPadrao : ContentPage
{
    int count = 0;

    public PaginaExemploPadrao()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void BotaoVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}