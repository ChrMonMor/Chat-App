using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class ProfileView : ContentView
{
	public ProfileView(ProfileViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}