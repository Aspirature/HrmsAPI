using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebAPI.Models.MasterModels
{
    public class MasterDepartments
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }        

    }
}
