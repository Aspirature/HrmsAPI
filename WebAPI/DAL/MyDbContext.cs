
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.MasterModels;

namespace WebAPI.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<User> TBL_USER { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<EmployeeAddressModel> EmployeeAddressDetailsModel { get; set; }
        public DbSet<EmployeeEducational> EmployeeEducationalDetails { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperienceDetails { get; set; }
        public DbSet<EmployeeNational> EmployeeNationalDetails { get; set; }
        public DbSet<EmployeeProjectDetails> EmployeeProjectDetails { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddressDetails { get; set; }
        public DbSet<EmployeePersonalDetails> EmployeePersonalDetails { get; set; }
        public DbSet<Country> CountryDetails { get; set; }
        public DbSet<State> StateDetails { get; set; }
        public DbSet<District> DistrictDetails { get; set; }
        public DbSet<MasterLeaveTypes> MasterLeaveTypes { get; set; }
        public DbSet<EmployeeLeavesMaster> EmployeeLeavesMaster { get; set; }
        public DbSet<EmployeeLeaveDetails> EmployeeLeaveDetails { get; set; }
    }
}
