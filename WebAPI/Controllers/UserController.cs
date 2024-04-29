using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyDbContext _mDbContext;
        private readonly IUserService _userService;
        public UserController(MyDbContext myDbContext,IUserService userService)
        {
            _mDbContext = myDbContext;
            _userService = userService;
        }
        [HttpGet("getUserListAsync")]
        public async Task<List<User>> GetUserListAsync()
        {
            try
            {
                return await _userService.GetUserListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getUserAsync")]
        public async Task<bool> GetUserAsync(string userName, string password)
        {
            try
            {
                return await _userService.GetUserAsync(userName,password);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
