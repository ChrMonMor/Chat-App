using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class AdministrationView : ContentView
{
	public AdministrationView(AdministrationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}