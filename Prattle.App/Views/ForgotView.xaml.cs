using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class ForgotView : ContentView
{
	public ForgotView(ForgotViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}