
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
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<EmployeeEducational> EmployeeEducational { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperience { get; set; }
        public DbSet<EmployeeNational> EmployeeNational { get; set; }
        public DbSet<EmployeeProjectDetails> EmployeeProjectDetails { get; set; }
    }
}
