using Microsoft.EntityFrameworkCore;

namespace ShelterApi.Models
{
  public class ShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ShelterApiContext(DbContextOptions<ShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Scruff", Species = "Cat", Age = 7 },
          new Animal { AnimalId = 2, Name = "Henri", Species = "Cat", Age = 6 },
          new Animal { AnimalId = 3, Name = "Brownie", Species = "Dog", Age = 5 },
          new Animal { AnimalId = 4, Name = "Petunia", Species = "Dog", Age = 9 },
          new Animal { AnimalId = 5, Name = "Dart", Species = "Cat", Age = 1 }
        );
    }
  }
}