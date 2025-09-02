using Microsoft.EntityFrameworkCore;
using SmartRegistrationAPI.Models;
namespace SmartRegistrationAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
  //  public DbSet<StudentPersonalInfo> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
}
