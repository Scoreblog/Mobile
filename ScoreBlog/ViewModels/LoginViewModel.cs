
using System.ComponentModel;
using System.Windows.Input;

namespace ScoreBlog.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly ILoginService _loginService;
        private CancellationTokenSource _cancellationTokenSource;

        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;
            LoginCommand = new Command(OnLogin);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    OnPropertyChanged(nameof(ErrorMessage));
                }
            }
        }
        public ICommand LoginCommand { get; }
        private async void OnLogin()
        {

            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _cancellationTokenSource.Token;

            try
            {
                var response = await _loginService.Login(Email, Password, cancellationToken);

                if (response.IsSuccess)
                {
                    ErrorMessage = "Login bem-sucedido!";
                }
                else
                {
                    ErrorMessage = "Usuário ou senha inválidos!";
                }
            }
            catch (TaskCanceledException)
            {
                ErrorMessage = "A operação foi cancelada.";
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Erro: {ex.Message}";
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
