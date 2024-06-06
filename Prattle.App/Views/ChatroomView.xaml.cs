using Prattle.App.ViewModels;

namespace Prattle.App.Views;

public partial class ChatroomView : ContentView
{
	public ChatroomView(ChatroomViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}