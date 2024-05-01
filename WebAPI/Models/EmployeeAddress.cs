using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebAPI.Models
{
    public class EmployeeAddress
    {

        [Key]
        public int EMPLOYEEADDRESSID { get; set; }
        public string ADDRESSTYPE { get; set; }
        public string ADDRESS { get; set; }
        public string ADDRESSLINE1 { get; set; }
        public string ADDRESSLINE2 { get; set; }
        public string PINCODE { get; set; }
        public int EMPLOYEEID { get; set; }
        public int COUNTRYID { get; set; }
        public int STATEID { get; set; }
        public int DISTRICTID { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string DISTRICTNAME { get; set; }


    }
}
