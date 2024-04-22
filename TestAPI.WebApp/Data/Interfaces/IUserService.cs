using TestAPI.WebApp.Data.Models;

namespace TestAPI.WebApp.Data.Contracts
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAll();
    }
}
