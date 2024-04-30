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
        public async Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName)
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
        [HttpGet("getEmployeeAddressDetailsAsync")]
        public async Task<List<EmployeeAddress>> GetEmployeeAddressDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeAddressDetailsAsync(empID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getEmployeeEduDetailsAsync")]
        public async Task<List<EmployeeEducational>> GetEmployeeEduDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeEduDetailsAsync(empID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getEmployeeExpDetailsAsync")]
        public async Task<List<EmployeeExperience>> GetEmployeeExpDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeExpDetailsAsync(empID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getEmployeeNationalDetailsAsync")]
        public async Task<List<EmployeeNational>> GetEmployeeNationalDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeNationalDetailsAsync(empID);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getEmployeeProjectDetailsAsync")]
        public async Task<List<EmployeeProjectDetails>> GetEmployeeProjectDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeProjectDetailsAsync(empID);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
