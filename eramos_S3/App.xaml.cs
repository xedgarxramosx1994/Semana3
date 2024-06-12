using MauiApp1;

namespace eramos_S3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Login());
	}
}
