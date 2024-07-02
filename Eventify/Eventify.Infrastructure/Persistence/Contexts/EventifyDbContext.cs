using Eventify.Domain;
using Microsoft.EntityFrameworkCore;

namespace Eventify.Infrastructure;

public class EventifyDbContext : DbContext
{
    public DbSet<Event> Events { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=EventifyDb;User Id=postgres;Password=mysecretpassword;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>()
            .OwnsOne(e => e.Location);

        modelBuilder.SeedEvent();
                
                
    }
}
