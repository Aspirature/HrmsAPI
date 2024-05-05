using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class EmployeeLeavesMaster
    {
        [Key]
        public int EmployeeLeavesMasterId { get; set; }
        public int TotalLeaveCount { get; set; }
        public int UsedLeavesCount { get; set; }
        public int UnUsedLeavesCount { get; set; }
        public Boolean IsActive { get; set; }
        public int EMPLOYEEID { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
