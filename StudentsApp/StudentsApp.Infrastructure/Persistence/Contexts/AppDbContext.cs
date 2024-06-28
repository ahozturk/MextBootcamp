using Microsoft.EntityFrameworkCore;
using StudentsApp.Domain;

namespace StudentsApp.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Lecture> Lectures { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=StudentsAppDb;Username=postgres;Password=mysecretpassword");
    }
}
