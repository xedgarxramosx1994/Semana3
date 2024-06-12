namespace MauiApp1;

public partial class vPrincipal : ContentPage
{
	public string user;
	public vPrincipal()
	{
		InitializeComponent();
	}
	public vPrincipal(string user)
	{
		InitializeComponent();
		this.user = user;
		txtWelcome.Text = "Bienvenido " + user;
	}
}