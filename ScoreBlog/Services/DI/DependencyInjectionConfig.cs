using ScoreBlog.Services;
using ScoreBlog.ViewModels;
using ScoreBlog.Views;

namespace ScoreBlog; 

public static class DependencyInjectionConfig
{
    public static void RegisterDependencies(IServiceCollection services)
    {
        services.AddSingleton<IApiService, ApiService>();
        services.AddSingleton<ILoginService, LoginService>();
        services.AddSingleton<LoginViewModel>();
        services.AddSingleton<LoginPage>();
        services.AddHttpClient();
    }
}
