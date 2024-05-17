using WebAPI.Models;
using WebAPI.Models.MasterModels;

namespace WebAPI.Interfaces
{
    public interface IEmployeeService
    {        
        public Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName);
        public Task<IEnumerable<EmployeeAddress>> GetEmployeeAddressDetailsAsync(int empID);
        public Task<List<EmployeeEducational>> GetEmployeeEduDetailsAsync(int empID);
        public Task<List<EmployeeExperience>> GetEmployeeExpDetailsAsync(int empID);
        public Task<List<EmployeeNational>> GetEmployeeNationalDetailsAsync(int empID);
        public Task<List<EmployeeProjectDetails>> GetEmployeeProjectDetailsAsync(int empID);
        public Task<List<RoleModel>> GetRolesListAsync();
        public Task<List<RoleModel>> GetRoleByIdAsync(int roleId);
        public Task<List<EmployeePersonalDetails>> GetEmployeePersonalDetailsAsync(int empID);
        public Task<int> AddUserAsync(User user);
        public Task<int> AddEmployeeAsync(EmployeeDetails employeeDetails);
        public Task<int> AddEmployeeAddressAsync(List<EmployeeAddress> employeeAddress);
        public Task<int> AddEmployeeEducationAsync(List<EmployeeEducational> employeeEducational);
        public Task<int> AddEmployeeExperienceAsync(List<EmployeeExperience> employeeExperience);
        public Task<int> AddEmployeeNationalAsync(EmployeeNational employeeNational);
        public Task<int> AddEmployeePersonalAsync(EmployeePersonalDetails employeePersonalDetails);
        public Task<int> AddEmployeeProjectAsync(EmployeeProjectDetails employeeProject);
        public Task<List<EmployeeLeavesMaster>> GetEmployeeLeavesMasterAsync(int empID);
        public Task<int> AddEmployeeLeaveDetailsAsync(EmployeeLeaveDetails employeeLeaveDetails);
        public Task<List<EmployeeLeaveDetails>> GetEmployeeLeaveDetailsAsync(int empID);
        public Task<List<EmployeeLeaveDetails>> GetEmployeeLeaveDetailsByIdAsync(int employeeLeaveDetailsId);
        public Task<List<EmployeeLeaveDetails>> GetPendingEmployeeLeaveDetailsForHMAsync(int homeManagerId);
        public Task<int> UpdatetEmployeeLeaveDetailsByIdAsync(EmployeeLeaveDetails employeeLeaveDetails);
        public Task<int> deleteEmployeeLeaveDetailsByIdAsync(EmployeeLeaveDetails employeeLeaveDetails);


    }
}
