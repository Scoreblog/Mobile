
using ScoreBlog.Models;
using ScoreBlog.Services;

namespace ScoreBlog;
public class LoginService(IHttpClientFactory httpClientFactory) : ApiService(httpClientFactory), ILoginService
{
    public Task<LoginResponse> Login(string email, string password, CancellationToken cancellationToken)
    {
        LoginRequest loginRequest = new LoginRequest(email, password);
        return PostAsync<LoginResponse>("/login", loginRequest, cancellationToken);
    }
}


