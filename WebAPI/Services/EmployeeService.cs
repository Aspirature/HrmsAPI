using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class EmployeeService : IEmployeeService
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
                var param = new SqlParameter("@empID", empID);
                var empAddDetails = await Task.Run(() => _myDbContext.EmployeeAddressDetails.FromSqlRaw(@"exec usp_GetEmpAddressDetails @empID", param).ToListAsync());
                return empAddDetails;
                // return await _myDbContext.EmployeeAddressDetails.Where(x => x.EMPLOYEEID == empID).ToListAsync();
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
                return await _myDbContext.EmployeeEducationalDetails.Where(x => x.EMPLOYEEID == empID).ToListAsync();
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
                return await _myDbContext.EmployeeExperienceDetails.Where(x => x.EMPLOYEEID == empID).ToListAsync();
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
                return await _myDbContext.EmployeeNationalDetails.Where(x => x.EMPLOYEEID == empID).ToListAsync();
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
