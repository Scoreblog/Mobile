using ScoreBlog.Services;
using ScoreBlog.ViewModels;
using ScoreBlog.Views;

namespace ScoreBlog; 

public static class DependencyInjectionConfig
{
    public static void RegisterDependencies(IServiceCollection services)
    {
        services.AddTransient<IApiService, ApiService>();
        services.AddTransient<ILoginService, LoginService>();
        services.AddTransient<LoginViewModel>();
        services.AddTransient<LoginPage>();
        services.AddHttpClient();
    }
}
