using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAPI.Models
{
    public class EmployeeLeaveDetails
    {
        [Key]
        public int EmployeeLeaveDetailsId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NoOfDays { get; set; }
        public string EmployeeComments { get; set; }
        public Boolean HalfDay { get; set; }
        public Boolean FullDay { get; set; }
        public Boolean IsManagerApproves { get; set; }
        public string ManagerComments { get; set; }
        public Boolean IsActive { get; set; }
        public int EMPLOYEEID { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
