using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.MasterModels
{
    public class MasterLeaveTypes
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string LeaveName { get; set; }
        public Boolean IsActive { get; set; }
    }
}
