using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Foster> Fosters  { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
                .HasData(
                    new Animal { AnimalId = 1, AnimalName = "Bartleby", Species = "Dog", Breed = "Spitz", Gender = "Male", Age = 2 },
                    new Animal { AnimalId = 2, AnimalName = "Sushi", Species = "Cat", Breed = "Calico", Gender = "Female", Age = 12 },
                    new Animal { AnimalId = 3, AnimalName = "Lester", Species = "Cat", Breed = "American Shorthair", Gender = "Male", Age = 6 },
                    new Animal { AnimalId = 4, AnimalName = "Neville", Species = "Dog", Breed = "English Setter", Gender = "Male", Age = 12 },
                    new Animal { AnimalId = 5, AnimalName = "Totoro", Species = "Sprite", Breed = "Unknown", Gender = "NA", Age = 1000 }
                );
        }
    }
}