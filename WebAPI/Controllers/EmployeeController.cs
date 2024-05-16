using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.MasterModels;

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
        [HttpGet("getEmployeeDetailsAsync")]
        public async Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName)
        {
            try
            {
                return await _employeeService.GetEmployeeDetailsAsync(userName);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeeAddressDetailsAsync")]
        public async Task<IEnumerable<EmployeeAddress>> GetEmployeeAddressDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeAddressDetailsAsync(empID);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeeEduDetailsAsync")]
        public async Task<List<EmployeeEducational>> GetEmployeeEduDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeEduDetailsAsync(empID);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeeExpDetailsAsync")]
        public async Task<List<EmployeeExperience>> GetEmployeeExpDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeExpDetailsAsync(empID);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeeNationalDetailsAsync")]
        public async Task<List<EmployeeNational>> GetEmployeeNationalDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeNationalDetailsAsync(empID);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeeProjectDetailsAsync")]
        public async Task<List<EmployeeProjectDetails>> GetEmployeeProjectDetailsAsync(int empID)
        {
            try
            {
                return await _employeeService.GetEmployeeProjectDetailsAsync(empID);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getRolesListAsync")]
        public async Task<List<RoleModel>> GetRolesListAsync()
        {
            try
            {
                return await _employeeService.GetRolesListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getRoleByIdAsync")]
        public async Task<List<RoleModel>> GetRoleByIdAsync(int roleId)
        {
            try
            {
                return await _employeeService.GetRoleByIdAsync(roleId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeePersonalDetailsAsync")]
        public async Task<List<EmployeePersonalDetails>> GetEmployeePersonalDetailsAsync(int empId)
        {
            try
            {
                return await _employeeService.GetEmployeePersonalDetailsAsync(empId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("GetEmployeeLeaveDetailsAsync")]
        public async Task<List<EmployeeLeaveDetails>> GetEmployeeLeaveDetailsAsync(int empId)
        {
            try
            {
                return await _employeeService.GetEmployeeLeaveDetailsAsync(empId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        #region Add Employee Details

        [HttpPost("addUserAsync")]
        public async Task<IActionResult> AddUserAsync(User user)
        {
            try
            {
                var responce=  await _employeeService.AddUserAsync(user);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}" , e);
            }
        }
        [HttpPost("addEmployeeAsync")]
        public async Task<IActionResult> AddEmployeeAsync(EmployeeDetails employeeDetails)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeAsync(employeeDetails);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeeAddressAsync")]
        public async Task<IActionResult> AddEmployeeAddressAsync(List<EmployeeAddress> employeeAddress)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeAddressAsync(employeeAddress);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeeEducationAsync")]
        public async Task<IActionResult> AddEmployeeEducationAsync(List<EmployeeEducational> employeeEducational)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeEducationAsync(employeeEducational);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeeExperienceAsync")]
        public async Task<IActionResult> AddEmployeeExperienceAsync(List<EmployeeExperience> employeeExperience)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeExperienceAsync(employeeExperience);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeeNationalAsync")]
        public async Task<IActionResult> AddEmployeeNationalAsync(EmployeeNational employeeNational)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeNationalAsync(employeeNational);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeePersonalAsync")]
        public async Task<IActionResult> AddEmployeePersonalAsync(EmployeePersonalDetails employeePersonalDetails)
        {
            try
            {
                var responce = await _employeeService.AddEmployeePersonalAsync(employeePersonalDetails);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeeProjectAsync")]
        public async Task<IActionResult> AddEmployeeProjectAsync(EmployeeProjectDetails employeeProject)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeProjectAsync(employeeProject);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getEmployeeLeavesMasterAsync")]
        public async Task<List<EmployeeLeavesMaster>> GetEmployeeLeavesMasterAsync(int empId)
        {
            try
            {
                return await _employeeService.GetEmployeeLeavesMasterAsync(empId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpPost("addEmployeeLeaveDetailsAsync")]
        public async Task<IActionResult> AddEmployeeLeaveDetailsAsync(EmployeeLeaveDetails employeeLeaveDetails)
        {
            try
            {
                var responce = await _employeeService.AddEmployeeLeaveDetailsAsync(employeeLeaveDetails);
                return Ok(responce);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        #endregion
    }
}
