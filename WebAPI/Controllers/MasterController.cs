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
    public class MasterController : ControllerBase
    {
        private readonly MyDbContext _mDbContext;
        private readonly IMasterService _masterService;
        public MasterController(MyDbContext myDbContext, IMasterService masterService)
        {
            _mDbContext = myDbContext;
            _masterService = masterService;
        }
        [HttpGet("getRoleListAsync")]
        public async Task<List<RoleModel>> GetRoleListAsync()
        {
            try
            {
                return await _masterService.GetRoleListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getRoleByRoleIdAsync")]
        public async Task<List<RoleModel>> GetRoleByRoleIdAsync(int roleId)
        {
            try
            {
                return await _masterService.GetRoleByRoleIdAsync(roleId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getCountryListAsync")]
        public async Task<List<Country>> GetCountryListAsync()
        {
            try
            {
                return await _masterService.GetCountryListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getStateListAsync")]
        public async Task<List<State>> GetStateListAsync()
        {
            try
            {
                return await _masterService.GetStateListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("geDistrictListAsync")]
        public async Task<List<District>> GeDistrictListAsync()
        {
            try
            {
                return await _masterService.GeDistrictListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getStateListByCountryIdAsync")]
        public async Task<List<State>> GetStateListByCountryIdAsync(int countryId)
        {
            try
            {
                return await _masterService.GetStateListByCountryIdAsync(countryId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getDistrictListByStateIdAsync")]
        public async Task<List<District>> GetDistrictListByStateIdAsync(int stateId)
        {
            try
            {
                return await _masterService.GetDistrictListByStateIdAsync(stateId);
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
        [HttpGet("getMasterLeavesTypesAsync")]
        public async Task<List<MasterLeaveTypes>> GetMasterLeavesTypesAsync()
        {
            try
            {
                return await _masterService.GetMasterLeavesTypesAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Controller level. {e.Message}", e);
            }
        }
    }
}
