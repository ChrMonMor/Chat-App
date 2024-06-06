using Prattle.App.Views;

namespace Prattle.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
            Routing.RegisterRoute(nameof(RegisterView), typeof(RegisterView));
            Routing.RegisterRoute(nameof(ForgotView), typeof(ForgotView));

            Routing.RegisterRoute(nameof(ProfileView), typeof(ProfileView));
            Routing.RegisterRoute(nameof(ServerView), typeof(ServerView));
            Routing.RegisterRoute(nameof(ChatroomView), typeof(ChatroomView));

            Routing.RegisterRoute(nameof(AdministrationView), typeof(AdministrationView));
        }
    }
}
