using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IEmployeeService
    {
        //public Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName);
        public Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName);
        public Task<List<EmployeeAddress>> GetEmployeeAddressDetailsAsync(int empID);
        public Task<List<EmployeeEducational>> GetEmployeeEduDetailsAsync(int empID);
        public Task<List<EmployeeExperience>> GetEmployeeExpDetailsAsync(int empID);
        public Task<List<EmployeeNational>> GetEmployeeNationalDetailsAsync(int empID);
        public Task<List<EmployeeProjectDetails>> GetEmployeeProjectDetailsAsync(int empID);
    }
}
