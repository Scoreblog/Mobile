namespace ScoreBlog;

public interface ILoginService : IApiService
{
    Task<LoginResponse> Login(string email, string password, CancellationToken cancellationToken);
}
