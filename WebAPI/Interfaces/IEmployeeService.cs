using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IEmployeeService
    {
        //public Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName);
        public Task<IEnumerable<EmployeeDetails>> GetEmployeeDetailsAsync(string userName);
    }
}
