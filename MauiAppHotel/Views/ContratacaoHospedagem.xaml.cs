namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
	private async void Button_Clicked_Sobre(Object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}