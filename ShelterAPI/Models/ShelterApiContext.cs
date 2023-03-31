using Microsoft.EntityFrameworkCore;

namespace ShelterAPI.Models
{
  public class ShelterAPIContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ShelterAPIContext(DbContextOptions<ShelterAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Scruff", Species = "cat", Age = 7, Gender = "male" },
          new Animal { AnimalId = 2, Name = "Henri", Species = "cat", Age = 6, Gender = "female" },
          new Animal { AnimalId = 3, Name = "Brownie", Species = "dog", Age = 5, Gender = "male" },
          new Animal { AnimalId = 4, Name = "Petunia", Species = "dog", Age = 9, Gender = "female" },
          new Animal { AnimalId = 5, Name = "Dart", Species = "cat", Age = 1, Gender = "unknown" }
        );
    }
  }
}