using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebAPI.Models.MasterModels
{
    public class State
    {
        [Key]
        public int STATEID { get; set; }
        public string STATE { get; set; }
        public int COUNTRYID { get; set; }
        
    }
}
