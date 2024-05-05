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
        public string BloodGroup { get; set; }
        public string PrimaryPhNo { get; set; }
        public string SecondaryPhNo { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyPhNo { get; set; }
        public string EmergencyContactRelation { get; set; }

    }
}
