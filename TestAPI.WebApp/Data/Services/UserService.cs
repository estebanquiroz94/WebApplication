using Microsoft.Extensions.Options;
using TestAPI.WebApp.Data.Common;
using TestAPI.WebApp.Data.Contracts;
using TestAPI.WebApp.Data.Models;

namespace TestAPI.WebApp.Data.Services
{
    public class UserService : IUserService
    {
        readonly HttpClient _httpClient;
        readonly AppSettings _appSettings;

        public UserService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            BaseServices<IEnumerable<User>, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.GetAll(_appSettings.UserAPI);
        }
    }
}
