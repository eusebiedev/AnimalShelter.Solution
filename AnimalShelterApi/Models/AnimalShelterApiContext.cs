using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Alice", Species = "Cat", Breed = "Siamese", Age = 1 },
          new Animal { AnimalId = 2, Name = "Barky", Species = "Cat", Breed = "Ragdoll", Age = 3 },
          new Animal { AnimalId = 3, Name = "Wirey", Species = "Cat", Breed = "Ocicat", Age = 5 },
          new Animal { AnimalId = 4, Name = "Bianca", Species = "Cat", Breed = "Chausie", Age = 7 },
          new Animal { AnimalId = 5, Name = "Flame", Species = "Cat", Breed = "Abyssinian", Age = 5 },
          new Animal { AnimalId = 6, Name = "Georia", Species = "Cat", Breed = "Birman", Age = 6 },
          new Animal { AnimalId = 7, Name = "Frisky", Species = "Cat", Breed = "Chartreux", Age = 7 },
          new Animal { AnimalId = 8, Name = "Sleepy", Species = "Cat", Breed = "Himalayan", Age = 3 },
          new Animal { AnimalId = 9, Name = "Curly", Species = "Cat", Breed = "Lyoki", Age = 3 },
          new Animal { AnimalId = 10, Name = "Bicker", Species = "Dog", Breed = "Chihuahua", Age = 11 },
          new Animal { AnimalId = 11, Name = "Snipper", Species = "Dog", Breed = "Pomeranian", Age = 4 },
          new Animal { AnimalId = 12, Name = "Wiley", Species = "Dog", Breed = "Havanese", Age = 4 },
          new Animal { AnimalId = 13, Name = "Frank", Species = "Dog", Breed = "Dachshund", Age = 8 },
          new Animal { AnimalId = 14, Name = "Charlie", Species = "Dog", Breed = "Bichon", Age = 11 },
          new Animal { AnimalId = 15, Name = "Rue", Species = "Dog", Breed = "Terrier", Age = 9 },
          new Animal { AnimalId = 16, Name = "Googlie", Species = "Dog", Breed = "Poodle", Age = 5 },
          new Animal { AnimalId = 17, Name = "Mike", Species = "Dog", Breed = "Affenpinscher", Age = 8 },
          new Animal { AnimalId = 18, Name = "Wolfie", Species = "Dog", Breed = "Sarabi", Age = 9 },
          new Animal { AnimalId = 19, Name = "Chomper", Species = "Dog", Breed = "Samoyed", Age = 3 },
          new Animal { AnimalId = 20, Name = "Sleepy", Species = "Dog", Breed = "Maltipoo", Age = 15 }
        );
    }
  }
}