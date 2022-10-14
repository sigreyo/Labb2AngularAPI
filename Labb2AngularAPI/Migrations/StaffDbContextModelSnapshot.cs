﻿// <auto-generated />
using System;
using Labb2AngularAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2AngularAPI.Migrations
{
    [DbContext(typeof(StaffDbContext))]
    partial class StaffDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb2AngularAPI.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Leksaker, Filmer & Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Datorer & Musik"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Böcker, Spel & Elektronik"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hälsa & Sport"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Smycken"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Böcker"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Leksaker & Spel"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Musik & Smycken"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Elektronik, Smycken & Livsmedel"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Musik, Trädgård & Verktyg"
                        });
                });

            modelBuilder.Entity("Labb2AngularAPI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Norra Kvarngränden 94",
                            DepartmentId = 6,
                            FirstName = "Petra",
                            Gender = "Female",
                            LastName = "Andersson",
                            Salary = 49331
                        },
                        new
                        {
                            Id = 2,
                            Address = "Västra Ekgatan 2",
                            DepartmentId = 7,
                            FirstName = "Ettie",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 42346
                        },
                        new
                        {
                            Id = 3,
                            Address = "Anderssons Väg 67",
                            DepartmentId = 4,
                            FirstName = "Mertie",
                            Gender = "Female",
                            LastName = "Gustafsson",
                            Salary = 42545
                        },
                        new
                        {
                            Id = 4,
                            Address = "Olssons Gata 1",
                            DepartmentId = 8,
                            FirstName = "Caleigh",
                            Gender = "Male",
                            LastName = "Olsson",
                            Salary = 44066
                        },
                        new
                        {
                            Id = 5,
                            Address = "Trädgårdgatan 88",
                            DepartmentId = 7,
                            FirstName = "Giuseppe",
                            Gender = "Male",
                            LastName = "Persson",
                            Salary = 36008
                        },
                        new
                        {
                            Id = 6,
                            Address = "Övre Industriallén 851",
                            DepartmentId = 2,
                            FirstName = "Antonina",
                            Gender = "Male",
                            LastName = "Olsson",
                            Salary = 49054
                        },
                        new
                        {
                            Id = 7,
                            Address = "Erikssons Gata 586",
                            DepartmentId = 10,
                            FirstName = "Durward",
                            Gender = "Female",
                            LastName = "Karlsson",
                            Salary = 33288
                        },
                        new
                        {
                            Id = 8,
                            Address = "Maximilians Gata 2",
                            DepartmentId = 2,
                            FirstName = "Ottis",
                            Gender = "Female",
                            LastName = "Nilsson",
                            Salary = 49025
                        },
                        new
                        {
                            Id = 9,
                            Address = "Övre Parkallén 708",
                            DepartmentId = 3,
                            FirstName = "Kendall",
                            Gender = "Male",
                            LastName = "Nilsson",
                            Salary = 50078
                        },
                        new
                        {
                            Id = 10,
                            Address = "Bäckallén 133",
                            DepartmentId = 9,
                            FirstName = "Mortimer",
                            Gender = "Female",
                            LastName = "Eriksson",
                            Salary = 42641
                        },
                        new
                        {
                            Id = 11,
                            Address = "Anderssons Gata 2",
                            DepartmentId = 2,
                            FirstName = "Angelita",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 58970
                        },
                        new
                        {
                            Id = 12,
                            Address = "Reannas Gata 282",
                            DepartmentId = 4,
                            FirstName = "Fermin",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 42320
                        },
                        new
                        {
                            Id = 13,
                            Address = "Abbeys Gata 35",
                            DepartmentId = 6,
                            FirstName = "Consuelo",
                            Gender = "Male",
                            LastName = "Nilsson",
                            Salary = 46889
                        },
                        new
                        {
                            Id = 14,
                            Address = "Trädgårdallén 419",
                            DepartmentId = 3,
                            FirstName = "Jimmy",
                            Gender = "Male",
                            LastName = "Andersson",
                            Salary = 34921
                        },
                        new
                        {
                            Id = 15,
                            Address = "Erikssons Väg 199",
                            DepartmentId = 1,
                            FirstName = "Britney",
                            Gender = "Male",
                            LastName = "Olsson",
                            Salary = 42927
                        },
                        new
                        {
                            Id = 16,
                            Address = "Johnathons Väg 63",
                            DepartmentId = 4,
                            FirstName = "Yasmin",
                            Gender = "Female",
                            LastName = "Larsson",
                            Salary = 45087
                        },
                        new
                        {
                            Id = 17,
                            Address = "Övre Kyrkvägen 1",
                            DepartmentId = 10,
                            FirstName = "Mollie",
                            Gender = "Female",
                            LastName = "Larsson",
                            Salary = 43403
                        },
                        new
                        {
                            Id = 18,
                            Address = "Undre Backgatan 079",
                            DepartmentId = 1,
                            FirstName = "Isobel",
                            Gender = "Female",
                            LastName = "Larsson",
                            Salary = 32265
                        },
                        new
                        {
                            Id = 19,
                            Address = "Wilfrids Väg 942",
                            DepartmentId = 3,
                            FirstName = "Stewart",
                            Gender = "Female",
                            LastName = "Karlsson",
                            Salary = 49991
                        },
                        new
                        {
                            Id = 20,
                            Address = "Olssons Gata 4",
                            DepartmentId = 7,
                            FirstName = "Else",
                            Gender = "Female",
                            LastName = "Gustafsson",
                            Salary = 55158
                        },
                        new
                        {
                            Id = 21,
                            Address = "Rashads Gata 8",
                            DepartmentId = 8,
                            FirstName = "Deborah",
                            Gender = "Female",
                            LastName = "Eriksson",
                            Salary = 34816
                        },
                        new
                        {
                            Id = 22,
                            Address = "Aidans Gata 06",
                            DepartmentId = 9,
                            FirstName = "Immanuel",
                            Gender = "Female",
                            LastName = "Larsson",
                            Salary = 34986
                        },
                        new
                        {
                            Id = 23,
                            Address = "Norra Stationsgränden 7",
                            DepartmentId = 5,
                            FirstName = "Celia",
                            Gender = "Female",
                            LastName = "Johansson",
                            Salary = 55809
                        },
                        new
                        {
                            Id = 24,
                            Address = "Undre Stationsvägen 28",
                            DepartmentId = 10,
                            FirstName = "Payton",
                            Gender = "Female",
                            LastName = "Persson",
                            Salary = 47847
                        },
                        new
                        {
                            Id = 25,
                            Address = "Jaquelines Gata 832",
                            DepartmentId = 10,
                            FirstName = "Andrew",
                            Gender = "Male",
                            LastName = "Svensson",
                            Salary = 44361
                        },
                        new
                        {
                            Id = 26,
                            Address = "Strandallén 274",
                            DepartmentId = 3,
                            FirstName = "Hobart",
                            Gender = "Male",
                            LastName = "Karlsson",
                            Salary = 38039
                        },
                        new
                        {
                            Id = 27,
                            Address = "Övre Åkergränden 87",
                            DepartmentId = 9,
                            FirstName = "Leatha",
                            Gender = "Female",
                            LastName = "Nilsson",
                            Salary = 54156
                        },
                        new
                        {
                            Id = 28,
                            Address = "Erwins Väg 196",
                            DepartmentId = 9,
                            FirstName = "Gabriella",
                            Gender = "Female",
                            LastName = "Eriksson",
                            Salary = 41477
                        },
                        new
                        {
                            Id = 29,
                            Address = "Aspvägen 677",
                            DepartmentId = 9,
                            FirstName = "Bobby",
                            Gender = "Male",
                            LastName = "Karlsson",
                            Salary = 38287
                        },
                        new
                        {
                            Id = 30,
                            Address = "Gustafssons Gata 847",
                            DepartmentId = 7,
                            FirstName = "Myrna",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 38910
                        },
                        new
                        {
                            Id = 31,
                            Address = "Salvadors Gata 13",
                            DepartmentId = 8,
                            FirstName = "Melba",
                            Gender = "Female",
                            LastName = "Olsson",
                            Salary = 56915
                        },
                        new
                        {
                            Id = 32,
                            Address = "Anderssons Väg 34",
                            DepartmentId = 5,
                            FirstName = "Kelley",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 51015
                        },
                        new
                        {
                            Id = 33,
                            Address = "Adellas Väg 89",
                            DepartmentId = 4,
                            FirstName = "Reva",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 48483
                        },
                        new
                        {
                            Id = 34,
                            Address = "Karlssons Väg 5",
                            DepartmentId = 7,
                            FirstName = "Jerod",
                            Gender = "Female",
                            LastName = "Andersson",
                            Salary = 55385
                        },
                        new
                        {
                            Id = 35,
                            Address = "Södra Furugärdet 17",
                            DepartmentId = 8,
                            FirstName = "Rosie",
                            Gender = "Female",
                            LastName = "Larsson",
                            Salary = 52595
                        },
                        new
                        {
                            Id = 36,
                            Address = "Ekgatan 59",
                            DepartmentId = 8,
                            FirstName = "Gerda",
                            Gender = "Male",
                            LastName = "Eriksson",
                            Salary = 57229
                        },
                        new
                        {
                            Id = 37,
                            Address = "Södra Granvägen 4",
                            DepartmentId = 5,
                            FirstName = "Gilda",
                            Gender = "Male",
                            LastName = "Olsson",
                            Salary = 33837
                        },
                        new
                        {
                            Id = 38,
                            Address = "Undre Kvarnvägen 43",
                            DepartmentId = 6,
                            FirstName = "Trisha",
                            Gender = "Female",
                            LastName = "Larsson",
                            Salary = 58876
                        },
                        new
                        {
                            Id = 39,
                            Address = "Marcuss Väg 728",
                            DepartmentId = 2,
                            FirstName = "Davonte",
                            Gender = "Female",
                            LastName = "Persson",
                            Salary = 46418
                        },
                        new
                        {
                            Id = 40,
                            Address = "Griffins Gata 9",
                            DepartmentId = 6,
                            FirstName = "Treva",
                            Gender = "Male",
                            LastName = "Svensson",
                            Salary = 51569
                        },
                        new
                        {
                            Id = 41,
                            Address = "Stationsgränden 16",
                            DepartmentId = 2,
                            FirstName = "Andy",
                            Gender = "Male",
                            LastName = "Andersson",
                            Salary = 46287
                        },
                        new
                        {
                            Id = 42,
                            Address = "Genvägen 4",
                            DepartmentId = 1,
                            FirstName = "Caden",
                            Gender = "Male",
                            LastName = "Gustafsson",
                            Salary = 58149
                        },
                        new
                        {
                            Id = 43,
                            Address = "Nygatan 256",
                            DepartmentId = 10,
                            FirstName = "Jasper",
                            Gender = "Male",
                            LastName = "Nilsson",
                            Salary = 37425
                        },
                        new
                        {
                            Id = 44,
                            Address = "Västra Furugärdet 62",
                            DepartmentId = 2,
                            FirstName = "Sunny",
                            Gender = "Male",
                            LastName = "Nilsson",
                            Salary = 54952
                        },
                        new
                        {
                            Id = 45,
                            Address = "Gustafssons Väg 414",
                            DepartmentId = 6,
                            FirstName = "Michale",
                            Gender = "Male",
                            LastName = "Johansson",
                            Salary = 49048
                        },
                        new
                        {
                            Id = 46,
                            Address = "Huberts Gata 36",
                            DepartmentId = 4,
                            FirstName = "Jailyn",
                            Gender = "Male",
                            LastName = "Svensson",
                            Salary = 38792
                        },
                        new
                        {
                            Id = 47,
                            Address = "Jaunitas Väg 21",
                            DepartmentId = 5,
                            FirstName = "Patrick",
                            Gender = "Male",
                            LastName = "Andersson",
                            Salary = 39783
                        },
                        new
                        {
                            Id = 48,
                            Address = "Kyrkogärdet 13",
                            DepartmentId = 3,
                            FirstName = "Michele",
                            Gender = "Female",
                            LastName = "Svensson",
                            Salary = 50228
                        },
                        new
                        {
                            Id = 49,
                            Address = "Carlies Gata 632",
                            DepartmentId = 4,
                            FirstName = "Rudolph",
                            Gender = "Female",
                            LastName = "Nilsson",
                            Salary = 51071
                        },
                        new
                        {
                            Id = 50,
                            Address = "Granvägen 539",
                            DepartmentId = 6,
                            FirstName = "Javonte",
                            Gender = "Female",
                            LastName = "Gustafsson",
                            Salary = 54205
                        });
                });

            modelBuilder.Entity("Labb2AngularAPI.Models.Department", b =>
                {
                    b.HasOne("Labb2AngularAPI.Models.Person", null)
                        .WithMany("Department")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Labb2AngularAPI.Models.Person", b =>
                {
                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
