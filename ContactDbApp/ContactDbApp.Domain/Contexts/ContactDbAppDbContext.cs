using Microsoft.EntityFrameworkCore;

namespace ContactDbApp.Domain;

public class ContactDbAppDbContext : DbContext
{
    public DbSet<Lecture> Lectures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("ContactDbApp");
    }
}
