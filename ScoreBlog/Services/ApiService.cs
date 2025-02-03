
using System.Net.Http.Json;

namespace ScoreBlog.Services
{
    public class ApiService : IApiService
    {
        private const string BaseUrl = "http://147.93.35.102:5070/v1";
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        public async Task<T> PostAsync<T>(string endPoint, object data, CancellationToken cancellationToken)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.PostAsJsonAsync($"{BaseUrl}{endPoint}", data, cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken);
        }
    }
}
