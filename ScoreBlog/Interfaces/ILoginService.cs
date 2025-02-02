namespace ScoreBlog;

internal interface ILoginService
{
    Task<LoginResponse> Login(string email, string password, CancellationToken cancellationToken);
}
