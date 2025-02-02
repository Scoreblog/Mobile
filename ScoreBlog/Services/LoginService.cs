
using ScoreBlog.Models;

namespace ScoreBlog;

internal class LoginService : ILoginService
{
    private readonly IApiService _apiService;
    public LoginService(IApiService apiService) => _apiService = apiService;
    public Task<LoginResponse> Login(string email, string password, CancellationToken cancellationToken)
    {
        LoginRequest loginRequest = new LoginRequest(email, password);
        return _apiService.PostAsync<LoginResponse>("/login", loginRequest, cancellationToken);
    }
}


