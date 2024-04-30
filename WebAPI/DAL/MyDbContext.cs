
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
    }
}
