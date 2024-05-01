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
        public string DATEOFBIRTH { get; set; }
        public string GENDER { get; set; }
        public string MATERIALSTATUS { get; set; }
        																									
    }
}
