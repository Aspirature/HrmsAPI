using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.Data.SqlClient;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.MasterModels;

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
        public async Task<IEnumerable<EmployeeAddress>> GetEmployeeAddressDetailsAsync(int empID)
        {
            try
            {
                var param = new SqlParameter("@empID", empID);
                var empAddDetails = await Task.Run(() => _myDbContext.EmployeeAddressDetails.
                FromSqlRaw(@"exec usp_GetEmpAddressDetails @empID", param).ToListAsync());
                return empAddDetails;

                //return await _myDbContext.EmployeeAddressDetails.FromSqlRaw<EmployeeAddress>("exec usp_GetEmpAddressDetails @empID", param).ToListAsync();

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
        public async Task<List<RoleModel>> GetRolesListAsync()
        {
            try
            {
                return await _myDbContext.Roles.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<EmployeePersonalDetails>> GetEmployeePersonalDetailsAsync(int empId)
        {
            try
            {
                return await _myDbContext.EmployeePersonalDetails.Where(x => x.EmployeeId == empId).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<RoleModel>> GetRoleByIdAsync(int roleId)
        {
            try
            {
                return await _myDbContext.Roles.Where(x => x.RoleId == roleId).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        #region Add Employee Details

        public async Task<int> AddUserAsync(User user)
        {
            int id;
            try
            {
                 _myDbContext.TBL_USER.Add(user);
                  await _myDbContext.SaveChangesAsync();
                //same id should pass in add employee employee details time
                  return id = user.USERID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeAsync(EmployeeDetails employeeDetails)
        {
            int id;
            try
            {
                _myDbContext.EmployeeDetails.Add(employeeDetails);
                await _myDbContext.SaveChangesAsync();               
                return id = employeeDetails.EMPLOYEEID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeNationalDetailsAsync(EmployeeNational employeeNational)
        {
            int id;
            try
            {
                _myDbContext.EmployeeNationalDetails.Add(employeeNational);
                await _myDbContext.SaveChangesAsync();
                return id = employeeNational.EMPLOYEEID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeAddressAsync(List<EmployeeAddress> employeeAddress)
        {
            int id;
            try
            {
                foreach (var item in employeeAddress)
                {
                    var newRecords = new EmployeeAddress();
                    newRecords.ADDRESS = item.ADDRESS;
                    newRecords.ADDRESSLINE1 = item.ADDRESSLINE1;
                    newRecords.ADDRESSLINE2 = item.ADDRESSLINE2;
                    newRecords.ADDRESSTYPE = item.ADDRESSTYPE;
                    newRecords.PINCODE = item.PINCODE;
                    newRecords.EMPLOYEEID = item.EMPLOYEEID;
                    newRecords.COUNTRYID = item.COUNTRYID;
                    newRecords.STATEID = item.STATEID;
                    newRecords.DISTRICTID = item.DISTRICTID;
                    _myDbContext.EmployeeAddressDetails.Add(newRecords);
                }
                await _myDbContext.SaveChangesAsync();
                return id = employeeAddress.Count;

                //_myDbContext.EmployeeAddressDetails.Add(employeeAddress);
                //await _myDbContext.SaveChangesAsync();
                //return id = employeeAddress.EMPLOYEEADDRESSID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeEducationAsync(List<EmployeeEducational> employeeEducational)
        {
            int id;
            try
            {
                foreach (var item in employeeEducational)
                {
                    var newRecords = new EmployeeEducational();
                    newRecords.COURSENAME = item.COURSENAME;
                    newRecords.DATEOFJOINED = item.DATEOFJOINED;
                    newRecords.DATEOFPASSEDOUT = item.DATEOFPASSEDOUT;
                    newRecords.EMPLOYEEEDUCATIONALID = item.EMPLOYEEEDUCATIONALID;
                    newRecords.PERCENTAGE = item.PERCENTAGE;
                    newRecords.INSTITUTIONADDRESS = item.INSTITUTIONADDRESS;
                    newRecords.EMPLOYEEID = item.EMPLOYEEID;                    
                    _myDbContext.EmployeeEducationalDetails.Add(newRecords);
                }
                await _myDbContext.SaveChangesAsync();
                return id = employeeEducational.Count;

                //_myDbContext.EmployeeEducationalDetails.Add(employeeEducational);
                //await _myDbContext.SaveChangesAsync();
                //return id = employeeEducational.EMPLOYEEEDUCATIONALID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeExperienceAsync(List<EmployeeExperience> employeeExperience)
        {
            int id;
            try
            {
                foreach (var item in employeeExperience)
                {
                    var newRecords = new EmployeeExperience();
                    newRecords.COMPANYNAME = item.COMPANYNAME;
                    newRecords.DESIGNATION = item.DESIGNATION;
                    newRecords.STARTDATE = item.STARTDATE;
                    newRecords.ENDDATE = item.ENDDATE;
                    newRecords.TOTALYEARSEXP = item.TOTALYEARSEXP;
                    newRecords.LASTDRAWNCTS = item.LASTDRAWNCTS;
                    newRecords.EMPLOYEEID = item.EMPLOYEEID;                   
                    _myDbContext.EmployeeExperienceDetails.Add(newRecords);
                }
                await _myDbContext.SaveChangesAsync();
                return id = employeeExperience.Count;
                //_myDbContext.EmployeeExperienceDetails.Add(employeeExperience);
                //await _myDbContext.SaveChangesAsync();
                //return id = employeeExperience.EMPLOYEEEXPERIENCEID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeNationalAsync(EmployeeNational employeeNational)
        {
            int id;
            try
            {
                _myDbContext.EmployeeNationalDetails.Add(employeeNational);
                await _myDbContext.SaveChangesAsync();
                return id = employeeNational.EMPLOYEENATIONALID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeePersonalAsync(EmployeePersonalDetails employeePersonalDetails)
        {
            int id;
            try
            {
                _myDbContext.EmployeePersonalDetails.Add(employeePersonalDetails);
                await _myDbContext.SaveChangesAsync();
                return id = employeePersonalDetails.EmployeePersonalId;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeProjectAsync(EmployeeProjectDetails employeeProject)
        {
            int id;
            try
            {
                _myDbContext.EmployeeProjectDetails.Add(employeeProject);
                await _myDbContext.SaveChangesAsync();
                return id = employeeProject.EMPLOYEEPROJECTDETAILSID;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<EmployeeLeavesMaster>> GetEmployeeLeavesMasterAsync(int empID)
        {
            try
            {
                return await _myDbContext.EmployeeLeavesMaster.Where(x => x.EMPLOYEEID == empID).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<int> AddEmployeeLeaveDetailsAsync(EmployeeLeaveDetails employeeLeaveDetails)
        {
            int id;
            try
            {
                _myDbContext.EmployeeLeaveDetails.Add(employeeLeaveDetails);
                await _myDbContext.SaveChangesAsync();
                return id = employeeLeaveDetails.EmployeeLeaveDetailsId;
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }       
        public async Task<List<EmployeeLeaveDetails>> GetEmployeeLeaveDetailsAsync(int empID)
        {
            try
            {
                return await _myDbContext.EmployeeLeaveDetails.Where(x => x.EMPLOYEEID == empID && x.IsActive).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeLeaveDetails>> GetEmployeeLeaveDetailsByIdAsync(int employeeLeaveDetailsId)
        {
            try
            {
                return await _myDbContext.EmployeeLeaveDetails.Where(x => x.EmployeeLeaveDetailsId == employeeLeaveDetailsId).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeLeaveDetails>> GetPendingEmployeeLeaveDetailsForHMAsync(int homeManagerId)
        {
            try
            {
                return await (from el in _myDbContext.EmployeeLeaveDetails
                           join ed in _myDbContext.EmployeeDetails on el.EMPLOYEEID equals ed.EMPLOYEEID
                           where ed.HomeManagerId == homeManagerId && el.IsManagerApproves == false && el.IsActive
                           select el).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> UpdatetEmployeeLeaveDetailsByIdAsync(EmployeeLeaveDetails employeeLeaveDetails)
        {
            try
            {
                var result = await _myDbContext.EmployeeLeaveDetails.Where(x => x.EmployeeLeaveDetailsId == employeeLeaveDetails.EmployeeLeaveDetailsId).FirstOrDefaultAsync();
                if (result != null)
                {
                    result.StartDate = employeeLeaveDetails.StartDate;
                    result.EndDate = employeeLeaveDetails.EndDate;
                    result.NoOfDays = employeeLeaveDetails.NoOfDays;
                    result.EmployeeComments = employeeLeaveDetails.EmployeeComments;
                    result.HalfDay = employeeLeaveDetails.HalfDay;
                    result.FullDay = employeeLeaveDetails.FullDay;
                    result.IsManagerApproves = employeeLeaveDetails.IsManagerApproves;
                    result.ManagerComments = employeeLeaveDetails.ManagerComments;
                    result.IsActive = employeeLeaveDetails.IsActive;
                    result.EMPLOYEEID = employeeLeaveDetails.EMPLOYEEID;
                    result.LeaveTypeId = employeeLeaveDetails.LeaveTypeId;
                    this._myDbContext.SaveChanges();                   
                }
                return employeeLeaveDetails.EmployeeLeaveDetailsId;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> deleteEmployeeLeaveDetailsByIdAsync(EmployeeLeaveDetails employeeLeaveDetails)
        {
            try
            {
                var result = await _myDbContext.EmployeeLeaveDetails.Where(x => x.EmployeeLeaveDetailsId == employeeLeaveDetails.EmployeeLeaveDetailsId).FirstOrDefaultAsync();
                if (result != null)
                {
                    
                    result.EmployeeComments = employeeLeaveDetails.EmployeeComments;                    
                    result.IsActive = false;                   
                    this._myDbContext.SaveChanges();
                }
                return employeeLeaveDetails.EmployeeLeaveDetailsId;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
