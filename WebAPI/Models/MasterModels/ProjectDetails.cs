using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.MasterModels
{
    public class ProjectDetails
    {
        [Key]
        public int PROJECTID { get; set; }
        public string PROJECTNAME { get; set; }
        public string COMPANYNAME { get; set; }

    }
}
