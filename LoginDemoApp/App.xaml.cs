using LoginDemoApp.Models;
using LoginDemoApp.ViewModels;
using LoginDemoApp.Views;
namespace LoginDemoApp;

public partial class App : Application
{
	public User LoggedInUser { get; set; }
	public App()
	{
		LoggedInUser = null;
		InitializeComponent();

		MainPage = new LoginView();
	}
}
