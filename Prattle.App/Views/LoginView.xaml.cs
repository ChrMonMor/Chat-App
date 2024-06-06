using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class LoginView : ContentView
{
	public LoginView(LoginViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}