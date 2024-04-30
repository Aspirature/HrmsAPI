using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using WebAPI.DAL;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class EmployeeService
    {
        private readonly MyDbContext _myDbContext;
        public EmployeeService(MyDbContext myDbContext) 
        {
            _myDbContext = myDbContext;
        }
        public async Task<IEnumerable<EmployeeDetails>> GetEmployeeDetailsAsync(string userName)
        {
            try
            {
                //return await _myDbContext.EmployeeDetails.ToListAsync();
                var param = new SqlParameter("@userName", userName);
                var empDetails = await Task.Run(() => _myDbContext.EmployeeDetails.FromSqlRaw(@"exec usp_Get_EmployeeDataByUserName @userName", param).ToListAsync());
                return empDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
