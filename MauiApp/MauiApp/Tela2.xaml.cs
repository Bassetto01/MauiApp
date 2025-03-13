namespace MauiApp;

public partial class Tela2 : ContentPage
{
	public Tela2()
	{
        InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		this.Navigation.PopAsync();
    }
}