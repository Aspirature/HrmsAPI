using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WebAPI.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int EMPLOYEEID { get; set; }
        public string USERNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public int AGE { get; set; }
        public int DATEOFBIRTH { get; set; }
        public int GENDER { get; set; }
        public int MATERIALSTATUS { get; set; }
        																									
    }
}
