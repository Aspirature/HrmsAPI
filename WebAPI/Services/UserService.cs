using Microsoft.EntityFrameworkCore;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly MyDbContext _myDbContext;
        public UserService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<List<User>> GetUserListAsync()
        {
            try
            {
                return await _myDbContext.TBL_USER.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> GetUserAsync(string userName, string password)
        {
            try
            {
                var user = await _myDbContext.TBL_USER.Where(x =>x.USERNAME == userName && x.PASSWORD == password && x.ISACTIVE == true).ToListAsync();
                if(user.Count >0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
