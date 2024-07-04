using GPTClone.Domain;
using Microsoft.EntityFrameworkCore;

namespace GPTClone.Infrastructure;

public class GPTCloneDbContext : DbContext
{
    public DbSet<Prompt> Prompts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=GPTCloneDb;Username=postgres;Password=mysecretpassword");
    }
}
