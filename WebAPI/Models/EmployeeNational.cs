using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class EmployeeNational
    {
        [Key]
        public int EMPLOYEENATIONALID { get; set; }
        public string PANNUMBER { get; set; }
        public string ADDHARNUMBER { get; set; }
        public string VOTERNUMBER { get; set; }
        public string PASSPORTNUMBER { get; set; }
        public string PASSPORTEXPDATE { get; set; }
        public string PASSPORTSTARTDATE { get; set; }
        public string PASSPORTISSUEOFFICE { get; set; }
        public int EMPLOYEEID { get; set; }
			
    }
}
