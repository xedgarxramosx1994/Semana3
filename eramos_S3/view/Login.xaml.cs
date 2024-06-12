namespace MauiApp1;

public partial class Login : ContentPage
{
	private readonly string user;
	private readonly string password;

	private readonly string[] tuplaUser;
	private readonly string[] tuplaPassword;


	public Login()
	{
		InitializeComponent();
	}

	public Login(string user, string password)
	{
		InitializeComponent();
		this.user = user;
		this.password = password;
		
	}

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
		if (user == null)
		{
			if (txtPassword.Text != null && txtUser.Text != null)
				Navigation.PushAsync(new vPrincipal(txtUser.Text));
			else
				DisplayAlert("Alerta", "Ingrese sus credenciales para ingresar.", "OK");
		}
		else
		{
			if (txtUser.Text == user && txtPassword.Text == password)
				Navigation.PushAsync(new vPrincipal(txtUser.Text));
			else
				DisplayAlert("Error", "Verifique sus credenciales.", "OK");
		}


	}
	private void btnRegister_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Register());
	}
}