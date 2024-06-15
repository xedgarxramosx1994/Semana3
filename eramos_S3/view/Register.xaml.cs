namespace MauiApp1;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
	private void btnRegister_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(txtUserNew.Text) && !string.IsNullOrEmpty(txtPasswordNew.Text))
		{
			DisplayAlert("Alerta", "Usuario creado con éxito", "OK");
			Navigation.PushAsync(new Login(txtUserNew.Text, txtPasswordNew.Text));
		}
		else
			DisplayAlert("Error", "Debe ingresar sus datos para crear el usuario", "OK");
	}
	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Login());
	}
}