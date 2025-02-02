using ScoreBlog.ViewModels;

namespace ScoreBlog;

internal static class DependencyInjectionConfig
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddSingleton<LoginViewModel>();
        services.AddHttpClient();
    }
}
