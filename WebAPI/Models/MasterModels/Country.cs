using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace WebAPI.Models.MasterModels
{
    public class Country
    {
        [Key]
        public int COUNTRYID { get; set; }
        public string COUNTRY { get; set; }
        public string COUNTRYCODE { get; set; }							
    }
}
