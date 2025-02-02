namespace ScoreBlog;

internal interface IApiService
{
    Task<T> PostAsync<T>(string endPoint,object data, CancellationToken cancellationToken);
}
