using LoginDemoApp.ViewModels;

namespace LoginDemoApp.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel(new Services.LoginDemoWebAPIProxy());
	}
}