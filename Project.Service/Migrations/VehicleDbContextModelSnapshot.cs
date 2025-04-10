﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Service.Database;

#nullable disable

namespace Project.Service.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    partial class VehicleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Project.Service.Models.VehicleMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abrv")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("VehicleMakes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abrv = "BMW",
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            Abrv = "FRD",
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 3,
                            Abrv = "VW",
                            Name = "Volkswagen"
                        },
                        new
                        {
                            Id = 4,
                            Abrv = "AUD",
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 5,
                            Abrv = "TYT",
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 6,
                            Abrv = "HND",
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 7,
                            Abrv = "CHV",
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 8,
                            Abrv = "MB",
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 9,
                            Abrv = "KIA",
                            Name = "Kia"
                        },
                        new
                        {
                            Id = 10,
                            Abrv = "NSN",
                            Name = "Nissan"
                        });
                });

            modelBuilder.Entity("Project.Service.Models.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abrv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("VehicleModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abrv = "X5",
                            MakeId = 1,
                            Name = "X5"
                        },
                        new
                        {
                            Id = 2,
                            Abrv = "3S",
                            MakeId = 1,
                            Name = "3 Series"
                        },
                        new
                        {
                            Id = 3,
                            Abrv = "5S",
                            MakeId = 1,
                            Name = "5 Series"
                        },
                        new
                        {
                            Id = 4,
                            Abrv = "7S",
                            MakeId = 1,
                            Name = "7 Series"
                        },
                        new
                        {
                            Id = 5,
                            Abrv = "M3",
                            MakeId = 1,
                            Name = "M3"
                        },
                        new
                        {
                            Id = 6,
                            Abrv = "M5",
                            MakeId = 1,
                            Name = "M5"
                        },
                        new
                        {
                            Id = 7,
                            Abrv = "X3",
                            MakeId = 1,
                            Name = "X3"
                        },
                        new
                        {
                            Id = 8,
                            Abrv = "X6",
                            MakeId = 1,
                            Name = "X6"
                        },
                        new
                        {
                            Id = 9,
                            Abrv = "Z4",
                            MakeId = 1,
                            Name = "Z4"
                        },
                        new
                        {
                            Id = 10,
                            Abrv = "I8",
                            MakeId = 1,
                            Name = "i8"
                        },
                        new
                        {
                            Id = 11,
                            Abrv = "MST",
                            MakeId = 2,
                            Name = "Mustang"
                        },
                        new
                        {
                            Id = 12,
                            Abrv = "F15",
                            MakeId = 2,
                            Name = "F-150"
                        },
                        new
                        {
                            Id = 13,
                            Abrv = "FCS",
                            MakeId = 2,
                            Name = "Focus"
                        },
                        new
                        {
                            Id = 14,
                            Abrv = "ESC",
                            MakeId = 2,
                            Name = "Escape"
                        },
                        new
                        {
                            Id = 15,
                            Abrv = "EXP",
                            MakeId = 2,
                            Name = "Explorer"
                        },
                        new
                        {
                            Id = 16,
                            Abrv = "RNG",
                            MakeId = 2,
                            Name = "Ranger"
                        },
                        new
                        {
                            Id = 17,
                            Abrv = "FSN",
                            MakeId = 2,
                            Name = "Fusion"
                        },
                        new
                        {
                            Id = 18,
                            Abrv = "TRN",
                            MakeId = 2,
                            Name = "Transit"
                        },
                        new
                        {
                            Id = 19,
                            Abrv = "EDG",
                            MakeId = 2,
                            Name = "Edge"
                        },
                        new
                        {
                            Id = 20,
                            Abrv = "FST",
                            MakeId = 2,
                            Name = "Fiesta"
                        },
                        new
                        {
                            Id = 21,
                            Abrv = "GLF",
                            MakeId = 3,
                            Name = "Golf"
                        },
                        new
                        {
                            Id = 22,
                            Abrv = "PST",
                            MakeId = 3,
                            Name = "Passat"
                        },
                        new
                        {
                            Id = 23,
                            Abrv = "JTA",
                            MakeId = 3,
                            Name = "Jetta"
                        },
                        new
                        {
                            Id = 24,
                            Abrv = "TGN",
                            MakeId = 3,
                            Name = "Tiguan"
                        },
                        new
                        {
                            Id = 25,
                            Abrv = "PLO",
                            MakeId = 3,
                            Name = "Polo"
                        },
                        new
                        {
                            Id = 26,
                            Abrv = "ARN",
                            MakeId = 3,
                            Name = "Arteon"
                        },
                        new
                        {
                            Id = 27,
                            Abrv = "TRG",
                            MakeId = 3,
                            Name = "Touareg"
                        },
                        new
                        {
                            Id = 28,
                            Abrv = "ALS",
                            MakeId = 3,
                            Name = "Atlas"
                        },
                        new
                        {
                            Id = 29,
                            Abrv = "BTL",
                            MakeId = 3,
                            Name = "Beetle"
                        },
                        new
                        {
                            Id = 30,
                            Abrv = "UP",
                            MakeId = 3,
                            Name = "Up!"
                        },
                        new
                        {
                            Id = 31,
                            Abrv = "A3",
                            MakeId = 4,
                            Name = "A3"
                        },
                        new
                        {
                            Id = 32,
                            Abrv = "A4",
                            MakeId = 4,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 33,
                            Abrv = "A6",
                            MakeId = 4,
                            Name = "A6"
                        },
                        new
                        {
                            Id = 34,
                            Abrv = "Q3",
                            MakeId = 4,
                            Name = "Q3"
                        },
                        new
                        {
                            Id = 35,
                            Abrv = "Q5",
                            MakeId = 4,
                            Name = "Q5"
                        },
                        new
                        {
                            Id = 36,
                            Abrv = "Q7",
                            MakeId = 4,
                            Name = "Q7"
                        },
                        new
                        {
                            Id = 37,
                            Abrv = "R8",
                            MakeId = 4,
                            Name = "R8"
                        },
                        new
                        {
                            Id = 38,
                            Abrv = "TT",
                            MakeId = 4,
                            Name = "TT"
                        },
                        new
                        {
                            Id = 39,
                            Abrv = "S3",
                            MakeId = 4,
                            Name = "S3"
                        },
                        new
                        {
                            Id = 40,
                            Abrv = "RS6",
                            MakeId = 4,
                            Name = "RS6"
                        },
                        new
                        {
                            Id = 41,
                            Abrv = "CRL",
                            MakeId = 5,
                            Name = "Corolla"
                        },
                        new
                        {
                            Id = 42,
                            Abrv = "CMR",
                            MakeId = 5,
                            Name = "Camry"
                        },
                        new
                        {
                            Id = 43,
                            Abrv = "RV4",
                            MakeId = 5,
                            Name = "RAV4"
                        },
                        new
                        {
                            Id = 44,
                            Abrv = "PRS",
                            MakeId = 5,
                            Name = "Prius"
                        },
                        new
                        {
                            Id = 45,
                            Abrv = "HLD",
                            MakeId = 5,
                            Name = "Highlander"
                        },
                        new
                        {
                            Id = 46,
                            Abrv = "TCM",
                            MakeId = 5,
                            Name = "Tacoma"
                        },
                        new
                        {
                            Id = 47,
                            Abrv = "YRS",
                            MakeId = 5,
                            Name = "Yaris"
                        },
                        new
                        {
                            Id = 48,
                            Abrv = "CHR",
                            MakeId = 5,
                            Name = "C-HR"
                        },
                        new
                        {
                            Id = 49,
                            Abrv = "SPR",
                            MakeId = 5,
                            Name = "Supra"
                        },
                        new
                        {
                            Id = 50,
                            Abrv = "LCR",
                            MakeId = 5,
                            Name = "Land Cruiser"
                        },
                        new
                        {
                            Id = 51,
                            Abrv = "CVC",
                            MakeId = 6,
                            Name = "Civic"
                        },
                        new
                        {
                            Id = 52,
                            Abrv = "ACD",
                            MakeId = 6,
                            Name = "Accord"
                        },
                        new
                        {
                            Id = 53,
                            Abrv = "CRV",
                            MakeId = 6,
                            Name = "CR-V"
                        },
                        new
                        {
                            Id = 54,
                            Abrv = "PLT",
                            MakeId = 6,
                            Name = "Pilot"
                        },
                        new
                        {
                            Id = 55,
                            Abrv = "ODY",
                            MakeId = 6,
                            Name = "Odyssey"
                        },
                        new
                        {
                            Id = 56,
                            Abrv = "FIT",
                            MakeId = 6,
                            Name = "Fit"
                        },
                        new
                        {
                            Id = 57,
                            Abrv = "HRV",
                            MakeId = 6,
                            Name = "HR-V"
                        },
                        new
                        {
                            Id = 58,
                            Abrv = "INS",
                            MakeId = 6,
                            Name = "Insight"
                        },
                        new
                        {
                            Id = 59,
                            Abrv = "RDL",
                            MakeId = 6,
                            Name = "Ridgeline"
                        },
                        new
                        {
                            Id = 60,
                            Abrv = "CLR",
                            MakeId = 6,
                            Name = "Clarity"
                        },
                        new
                        {
                            Id = 61,
                            Abrv = "CMR",
                            MakeId = 7,
                            Name = "Camaro"
                        },
                        new
                        {
                            Id = 62,
                            Abrv = "SLV",
                            MakeId = 7,
                            Name = "Silverado"
                        },
                        new
                        {
                            Id = 63,
                            Abrv = "CVT",
                            MakeId = 7,
                            Name = "Corvette"
                        },
                        new
                        {
                            Id = 64,
                            Abrv = "EQX",
                            MakeId = 7,
                            Name = "Equinox"
                        },
                        new
                        {
                            Id = 65,
                            Abrv = "MLB",
                            MakeId = 7,
                            Name = "Malibu"
                        },
                        new
                        {
                            Id = 66,
                            Abrv = "TRV",
                            MakeId = 7,
                            Name = "Traverse"
                        },
                        new
                        {
                            Id = 67,
                            Abrv = "SBN",
                            MakeId = 7,
                            Name = "Suburban"
                        },
                        new
                        {
                            Id = 68,
                            Abrv = "BLZ",
                            MakeId = 7,
                            Name = "Blazer"
                        },
                        new
                        {
                            Id = 69,
                            Abrv = "BOL",
                            MakeId = 7,
                            Name = "Bolt"
                        },
                        new
                        {
                            Id = 70,
                            Abrv = "CLD",
                            MakeId = 7,
                            Name = "Colorado"
                        },
                        new
                        {
                            Id = 71,
                            Abrv = "CCL",
                            MakeId = 8,
                            Name = "C-Class"
                        },
                        new
                        {
                            Id = 72,
                            Abrv = "ECL",
                            MakeId = 8,
                            Name = "E-Class"
                        },
                        new
                        {
                            Id = 73,
                            Abrv = "SCL",
                            MakeId = 8,
                            Name = "S-Class"
                        },
                        new
                        {
                            Id = 74,
                            Abrv = "GLC",
                            MakeId = 8,
                            Name = "GLC"
                        },
                        new
                        {
                            Id = 75,
                            Abrv = "GLE",
                            MakeId = 8,
                            Name = "GLE"
                        },
                        new
                        {
                            Id = 76,
                            Abrv = "ACL",
                            MakeId = 8,
                            Name = "A-Class"
                        },
                        new
                        {
                            Id = 77,
                            Abrv = "CLA",
                            MakeId = 8,
                            Name = "CLA"
                        },
                        new
                        {
                            Id = 78,
                            Abrv = "GCL",
                            MakeId = 8,
                            Name = "G-Class"
                        },
                        new
                        {
                            Id = 79,
                            Abrv = "SL",
                            MakeId = 8,
                            Name = "SL"
                        },
                        new
                        {
                            Id = 80,
                            Abrv = "AGT",
                            MakeId = 8,
                            Name = "AMG GT"
                        },
                        new
                        {
                            Id = 81,
                            Abrv = "SPT",
                            MakeId = 9,
                            Name = "Sportage"
                        },
                        new
                        {
                            Id = 82,
                            Abrv = "SRT",
                            MakeId = 9,
                            Name = "Sorento"
                        },
                        new
                        {
                            Id = 83,
                            Abrv = "OPT",
                            MakeId = 9,
                            Name = "Optima"
                        },
                        new
                        {
                            Id = 84,
                            Abrv = "SOL",
                            MakeId = 9,
                            Name = "Soul"
                        },
                        new
                        {
                            Id = 85,
                            Abrv = "FOR",
                            MakeId = 9,
                            Name = "Forte"
                        },
                        new
                        {
                            Id = 86,
                            Abrv = "TLR",
                            MakeId = 9,
                            Name = "Telluride"
                        },
                        new
                        {
                            Id = 87,
                            Abrv = "RIO",
                            MakeId = 9,
                            Name = "Rio"
                        },
                        new
                        {
                            Id = 88,
                            Abrv = "STR",
                            MakeId = 9,
                            Name = "Stinger"
                        },
                        new
                        {
                            Id = 89,
                            Abrv = "NRO",
                            MakeId = 9,
                            Name = "Niro"
                        },
                        new
                        {
                            Id = 90,
                            Abrv = "K5",
                            MakeId = 9,
                            Name = "K5"
                        },
                        new
                        {
                            Id = 91,
                            Abrv = "ALT",
                            MakeId = 10,
                            Name = "Altima"
                        },
                        new
                        {
                            Id = 92,
                            Abrv = "ROG",
                            MakeId = 10,
                            Name = "Rogue"
                        },
                        new
                        {
                            Id = 93,
                            Abrv = "SEN",
                            MakeId = 10,
                            Name = "Sentra"
                        },
                        new
                        {
                            Id = 94,
                            Abrv = "PTH",
                            MakeId = 10,
                            Name = "Pathfinder"
                        },
                        new
                        {
                            Id = 95,
                            Abrv = "MUR",
                            MakeId = 10,
                            Name = "Murano"
                        },
                        new
                        {
                            Id = 96,
                            Abrv = "VRS",
                            MakeId = 10,
                            Name = "Versa"
                        },
                        new
                        {
                            Id = 97,
                            Abrv = "TTN",
                            MakeId = 10,
                            Name = "Titan"
                        },
                        new
                        {
                            Id = 98,
                            Abrv = "LEF",
                            MakeId = 10,
                            Name = "Leaf"
                        },
                        new
                        {
                            Id = 99,
                            Abrv = "Z",
                            MakeId = 10,
                            Name = "Z"
                        },
                        new
                        {
                            Id = 100,
                            Abrv = "KCK",
                            MakeId = 10,
                            Name = "Kicks"
                        });
                });

            modelBuilder.Entity("Project.Service.Models.VehicleModel", b =>
                {
                    b.HasOne("Project.Service.Models.VehicleMake", "VehicleMake")
                        .WithMany("VehicleModels")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleMake");
                });

            modelBuilder.Entity("Project.Service.Models.VehicleMake", b =>
                {
                    b.Navigation("VehicleModels");
                });
#pragma warning restore 612, 618
        }
    }
}
