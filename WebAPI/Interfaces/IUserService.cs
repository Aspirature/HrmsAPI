using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IUserService
    {
        public Task<List<User>> GetUserListAsync();
        public Task<bool> GetUserAsync(string userName, string password);
    }
}
