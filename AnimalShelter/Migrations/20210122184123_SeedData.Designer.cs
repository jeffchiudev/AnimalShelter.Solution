﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20210122184123_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("AnimalName");

                    b.Property<string>("Breed");

                    b.Property<string>("Gender");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            AnimalName = "Bartleby",
                            Breed = "Spitz",
                            Gender = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 12,
                            AnimalName = "Sushi",
                            Breed = "Calico",
                            Gender = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 6,
                            AnimalName = "Lester",
                            Breed = "American Shorthair",
                            Gender = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 12,
                            AnimalName = "Neville",
                            Breed = "English Setter",
                            Gender = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 1000,
                            AnimalName = "Totoro",
                            Breed = "Unknown",
                            Gender = "NA",
                            Species = "Sprite"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Foster", b =>
                {
                    b.Property<int>("FosterId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("FosterAvailability");

                    b.Property<string>("FosterEmail");

                    b.Property<string>("FosterName");

                    b.HasKey("FosterId");

                    b.ToTable("Fosters");

                    b.HasData(
                        new
                        {
                            FosterId = 1,
                            FosterAvailability = true,
                            FosterEmail = "jeff@test.com",
                            FosterName = "Jeff"
                        },
                        new
                        {
                            FosterId = 2,
                            FosterAvailability = true,
                            FosterEmail = "sarah@test.com",
                            FosterName = "Sarah"
                        },
                        new
                        {
                            FosterId = 3,
                            FosterAvailability = false,
                            FosterEmail = "Doug@test.com",
                            FosterName = "Doug"
                        },
                        new
                        {
                            FosterId = 4,
                            FosterAvailability = true,
                            FosterEmail = "leon@test.com",
                            FosterName = "Leon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}