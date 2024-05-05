using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class EmployeeProjectDetails
    {
        [Key]
        public int EMPLOYEEPROJECTDETAILSID { get; set; }
        public string DESIGNATION { get; set; }
        public string LOCATION { get; set; }
        //public Boolean BILLABILITY { get; set; }
        public string PROJECTSTARTDATE { get; set; }
        public string PROJECTENDDATE { get; set; }
        public int PERCENTAGE { get; set; }
        public Boolean BILLABILITY { get; set; }
        public int MANAGERID { get; set; }
        public string MANAGERNAME { get; set; }
        public Boolean ISACTIVE { get; set; }
        public int EMPLOYEEID { get; set; }

    }
}
