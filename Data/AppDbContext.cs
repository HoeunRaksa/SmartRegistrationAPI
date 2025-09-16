using Microsoft.EntityFrameworkCore;
using SmartRegistrationAPI.Models;
namespace SmartRegistrationAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Department> Departments { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // TPH (Table Per Hierarchy) inheritance mapping
        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("UserType") // column name in table
            .HasValue<Student>("Student");
    }
}
