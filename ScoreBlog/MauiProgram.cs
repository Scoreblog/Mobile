using DotNet.Meteor.HotReload.Plugin;
using Microsoft.Extensions.Logging;

namespace ScoreBlog
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
#if DEBUG
            .EnableHotReload()
#endif
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Roboto-ExtraBold.ttf", "RobotoExtraBold");
                    fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                    fonts.AddFont("Roboto-Semibold.ttf", "RobotoSemibold");
                    fonts.AddFont("fontello.ttf", "IconsFont");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            DependencyInjectionConfig.RegisterDependencies(builder.Services);
            return builder.Build();
        }
    }
}
