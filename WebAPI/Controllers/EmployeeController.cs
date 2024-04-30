using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly MyDbContext _mDbContext;
        private readonly IEmployeeService _employeeService;
        public EmployeeController(MyDbContext myDbContext, IEmployeeService employeeService)
        {
            _mDbContext = myDbContext;
            _employeeService = employeeService;
        }

        //[HttpGet("getEmployeeDetailsAsync")]
        //public async Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName)
        //{
        //    try
        //    {
        //        return await _employeeService.GetEmployeeDetailsAsync(userName);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        [HttpGet("getEmployeeDetailsAsync")]
        public async Task<IEnumerable<EmployeeDetails>> GetEmployeeDetailsAsync(string userName)
        {
            try
            {
                return await _employeeService.GetEmployeeDetailsAsync(userName);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
