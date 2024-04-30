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
        public async Task<List<EmployeeDetails>> GetEmployeeDetailsAsync(string userName)
        {
            try
            {
                return await _myDbContext.EmployeeDetails.Where(x => x.USERNAME == userName).ToListAsync();
                //var param = new SqlParameter("@userName", userName);
                //var empDetails = await Task.Run(() => _myDbContext.EmployeeDetails.FromSqlRaw(@"exec usp_Get_EmployeeDataByUserName @userName", param).ToListAsync());
                //return empDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeAddress>> GetEmployeeAddressDetailsAsync(int empID)
        {
            try
            {
                //return await (from ad in _myDbContext.EmployeeAddress
                //              join emp in _myDbContext.EmployeeDetails on ad.EMPLOYEEID equals emp.EMPLOYEEID where ad.EMPLOYEEID == empID select ad).ToListAsync();
               
                return await _myDbContext.EmployeeAddress.Where(x => x.EMPLOYEEID == empID).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeEducational>> GetEmployeeEduDetailsAsync(int empID)
        {
            try
            {
                return await _myDbContext.EmployeeEducational.Where(x => x.EMPLOYEEID == empID).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeExperience>> GetEmployeeExpDetailsAsync(int empID)
        {
            try
            {
                return await _myDbContext.EmployeeExperience.Where(x => x.EMPLOYEEID == empID).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeNational>> GetEmployeeNationalDetailsAsync(int empID)
        {
            try
            {
                return await _myDbContext.EmployeeNational.Where(x => x.EMPLOYEEID == empID).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeProjectDetails>> GetEmployeeProjectDetailsAsync(int empID)
        {
            try
            {
                return await _myDbContext.EmployeeProjectDetails.Where(x => x.EMPLOYEEID == empID).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
