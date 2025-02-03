using System.Diagnostics;
using ScoreBlog.Views;

namespace ScoreBlog
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            try
            {
                var loginPage = _serviceProvider.GetRequiredService<LoginPage>();
                return new Window(loginPage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao criar a janela com LoginPage: {ex.Message}");
                throw;
            }
        }
    }
}