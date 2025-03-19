namespace MauiApp1;

public class CodigoPage : ContentPage
{
	public CodigoPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { 
					HorizontalOptions = LayoutOptions.End,
					VerticalOptions = LayoutOptions.Start, 
					Text = "Bem vindo"
				},
				new Label { 
					HorizontalOptions = LayoutOptions.End,
					VerticalOptions = LayoutOptions.Start,
					Text = "ao .NET MAUI"
				
				}
			}
		};
	}
}
