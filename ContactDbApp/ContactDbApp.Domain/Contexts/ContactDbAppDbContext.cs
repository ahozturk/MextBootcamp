using Microsoft.EntityFrameworkCore;

namespace ContactDbApp.Domain;

public class ContactDbAppDbContext : DbContext
{
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=myDataBase;User Id=postgres;Password=mysecretpassword");
    }
}
