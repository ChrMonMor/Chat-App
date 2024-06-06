using Prattle.App.Data.Interfaces;
using Prattle.App.Data.Services;
using Prattle.App.ViewModels;
using Prattle.App.Views;
using CommunityToolkit.Maui;

namespace Prattle.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseMauiCommunityToolkit();



            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddSingleton<IUserService, UserService>();
            builder.Services.AddSingleton<IChatroomService, ChatroomService>();


            builder.Services.AddSingleton<LoginView>();
            builder.Services.AddSingleton<LoginViewModel>();

            builder.Services.AddTransient<RegisterView>();
            builder.Services.AddTransient<RegisterViewModel>();

            builder.Services.AddTransient<ForgotView>();
            builder.Services.AddTransient<ForgotViewModel>();

            builder.Services.AddTransient<ProfileView>();
            builder.Services.AddTransient<ProfileViewModel>();

            builder.Services.AddTransient<ServerView>();
            builder.Services.AddTransient<ServerViewModel>();

            builder.Services.AddTransient<ChatroomView>();
            builder.Services.AddTransient<ChatroomViewModel>();

            builder.Services.AddTransient<AdministrationView>();
            builder.Services.AddTransient<AdministrationViewModel>();

            return builder.Build();
        }
    }
}
