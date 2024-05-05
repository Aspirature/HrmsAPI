using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebAPI.Models.MasterModels
{
    public class District
    {
        [Key]
        public int DISTRICTID { get; set; }
        public string DISTRICTNAME { get; set; }
        public int STATEID { get; set; }
       		
    }
}
