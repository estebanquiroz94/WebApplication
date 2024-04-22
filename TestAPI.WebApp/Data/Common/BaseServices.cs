namespace TestAPI.WebApp.Data.Common
{
    public class BaseServices<T,K>
    {
        readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public BaseServices(HttpClient httpClient, AppSettings appsettings)
        {
            _httpClient = httpClient;
            _appSettings = appsettings;
        }

        public async Task<T> GetAll(string url)
        {
            var result = await _httpClient.GetFromJsonAsync<T>($"{_appSettings.BaseUrl}{url}");
            return result!;
        }

        public async Task<T> Get(K parameter, string url)
        {
            var result = await _httpClient.GetFromJsonAsync<T>($"{_appSettings.BaseUrl}{string.Format(url, parameter)}");
            return result!;
        }
    }
}
