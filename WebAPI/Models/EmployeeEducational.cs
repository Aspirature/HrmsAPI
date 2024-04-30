using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class EmployeeEducational
    {
        [Key]
        public int EMPLOYEEEDUCATIONALID { get; set; }
        public string COURSENAME { get; set; }
        public string DATEOFJOINED { get; set; }
        public string DATEOFPASSEDOUT { get; set; }
        public decimal PERCENTAGE { get; set; }
        public int EMPLOYEEID { get; set; }
			
    }
}
