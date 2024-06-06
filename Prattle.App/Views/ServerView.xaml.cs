using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class ServerView : ContentView
{
	public ServerView(ServerViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}