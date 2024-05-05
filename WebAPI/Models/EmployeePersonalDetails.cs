using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class EmployeePersonalDetails
    {
        [Key]
        public int EmployeePersonalId { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int EmployeeId { get; set; }
        
    }
}
