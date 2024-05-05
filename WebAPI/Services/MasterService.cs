using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.Data.SqlClient;
using WebAPI.DAL;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.MasterModels;

namespace WebAPI.Services
{
    public class MasterService : IMasterService
    {
        private readonly MyDbContext _myDbContext;
        public MasterService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<List<RoleModel>> GetRoleListAsync()
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
        public async Task<List<RoleModel>> GetRoleByRoleIdAsync(int roleId)
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
        public async Task<List<Country>> GetCountryListAsync()
        {
            try
            {
                return await _myDbContext.CountryDetails.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<State>> GetStateListAsync()
        {
            try
            {
                return await _myDbContext.StateDetails.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<District>> GeDistrictListAsync()
        {
            try
            {
                return await _myDbContext.DistrictDetails.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<State>> GetStateListByCountryIdAsync(int countryId)
        {
            try
            {
                return await _myDbContext.StateDetails.Where(x => x.COUNTRYID == countryId).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<District>> GetDistrictListByStateIdAsync(int stateId)
        {
            try
            {
                return await _myDbContext.DistrictDetails.Where(x => x.STATEID == stateId).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        public async Task<List<MasterLeaveTypes>> GetMasterLeavesTypesAsync()
        {
            try
            {
                return await _myDbContext.MasterLeaveTypes.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"service level. {e.Message}", e);
            }
        }
        
    }
}
