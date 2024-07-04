using CommunityToolkit.Maui.Core;
using MauiTheme.Navigation;
using MauiTheme.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiTheme;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //Partie navigation
        builder.Services.AddSingleton<INavigationService, NavigationService>();

        //Inject VM
        builder.Services.AddSingleton<MainPageViewModel>();

        //Inject Views
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
