namespace ScoreBlog;

public interface IApiService
{
    Task<T> PostAsync<T>(string endPoint,object data, CancellationToken cancellationToken);
}
