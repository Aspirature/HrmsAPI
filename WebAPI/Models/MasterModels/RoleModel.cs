using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models.MasterModels    
{
    public class RoleModel
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public Boolean IsActive { get; set; }
    }
}
