using WebAPI.Models;
using WebAPI.Models.MasterModels;

namespace WebAPI.Interfaces
{
    public interface IMasterService
    {
        public Task<List<RoleModel>> GetRoleListAsync();
        public Task<List<RoleModel>> GetRoleByRoleIdAsync(int roleId);
        public Task<List<Country>> GetCountryListAsync();
        public Task<List<State>> GetStateListAsync();
        public Task<List<District>> GeDistrictListAsync();
        public Task<List<State>> GetStateListByCountryIdAsync(int countryId);
        public Task<List<District>> GetDistrictListByStateIdAsync(int stateId);
        public Task<List<MasterLeaveTypes>> GetMasterLeavesTypesAsync();
        public Task<List<MasterDepartments>> GetMasterDepartmentsAsync();
        public Task<List<MasterDesignations>> GetMasterDesignationsAsync();
    }
}
