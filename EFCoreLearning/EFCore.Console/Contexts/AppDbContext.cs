using EFCore.Console.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Console;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Lecture> Lectures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseInMemoryDatabase("MyFirstDb");
    }
}
