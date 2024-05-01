using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class EmployeeExperience
    {
        [Key]
        public int EMPLOYEEEXPERIENCEID { get; set; }
        public string COMPANYNAME { get; set; }
        public string DESIGNATION { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
        public double TOTALYEARSEXP { get; set; }
        public double LASTDRAWNCTS { get; set; }
        public int EMPLOYEEID { get; set; }
			
    }
}
