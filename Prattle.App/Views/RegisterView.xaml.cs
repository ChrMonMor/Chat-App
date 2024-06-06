using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class RegisterView : ContentView
{
	public RegisterView(RegisterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}