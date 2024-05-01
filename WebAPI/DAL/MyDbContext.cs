
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<User> TBL_USER { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddressDetails { get; set; }
        public DbSet<EmployeeEducational> EmployeeEducationalDetails { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperienceDetails { get; set; }
        public DbSet<EmployeeNational> EmployeeNationalDetails { get; set; }
        public DbSet<EmployeeProjectDetails> EmployeeProjectDetails { get; set; }
    }
}
