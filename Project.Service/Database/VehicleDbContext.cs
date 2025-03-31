using Project.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace Project.Service.Database
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options) { }
        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VehicleMake>().HasKey(m => m.Id);
            modelBuilder.Entity<VehicleModel>().HasKey(m => m.Id);

            //Seeding Initial Data
            modelBuilder.Entity<VehicleMake>().HasData(
        new VehicleMake { Id = 1, Name = "BMW", Abrv = "BMW" },
        new VehicleMake { Id = 2, Name = "Ford", Abrv = "FRD" },
        new VehicleMake { Id = 3, Name = "Volkswagen", Abrv = "VW" },
        new VehicleMake { Id = 4, Name = "Audi", Abrv = "AUD" },
        new VehicleMake { Id = 5, Name = "Toyota", Abrv = "TYT" },
        new VehicleMake { Id = 6, Name = "Honda", Abrv = "HND" },
        new VehicleMake { Id = 7, Name = "Chevrolet", Abrv = "CHV" },
        new VehicleMake { Id = 8, Name = "Mercedes", Abrv = "MB" },
        new VehicleMake { Id = 9, Name = "Kia", Abrv = "KIA" },
        new VehicleMake { Id = 10, Name = "Nissan", Abrv = "NSN" }
    );

            modelBuilder.Entity<VehicleModel>().HasData(
    // BMW (MakeId = 1)
    new VehicleModel { Id = 1, Name = "X5", Abrv = "X5", MakeId = 1 },
    new VehicleModel { Id = 2, Name = "3 Series", Abrv = "3S", MakeId = 1 },
    new VehicleModel { Id = 3, Name = "5 Series", Abrv = "5S", MakeId = 1 },
    new VehicleModel { Id = 4, Name = "7 Series", Abrv = "7S", MakeId = 1 },
    new VehicleModel { Id = 5, Name = "M3", Abrv = "M3", MakeId = 1 },
    new VehicleModel { Id = 6, Name = "M5", Abrv = "M5", MakeId = 1 },
    new VehicleModel { Id = 7, Name = "X3", Abrv = "X3", MakeId = 1 },
    new VehicleModel { Id = 8, Name = "X6", Abrv = "X6", MakeId = 1 },
    new VehicleModel { Id = 9, Name = "Z4", Abrv = "Z4", MakeId = 1 },
    new VehicleModel { Id = 10, Name = "i8", Abrv = "I8", MakeId = 1 },

    // Ford (MakeId = 2)
    new VehicleModel { Id = 11, Name = "Mustang", Abrv = "MST", MakeId = 2 },
    new VehicleModel { Id = 12, Name = "F-150", Abrv = "F15", MakeId = 2 },
    new VehicleModel { Id = 13, Name = "Focus", Abrv = "FCS", MakeId = 2 },
    new VehicleModel { Id = 14, Name = "Escape", Abrv = "ESC", MakeId = 2 },
    new VehicleModel { Id = 15, Name = "Explorer", Abrv = "EXP", MakeId = 2 },
    new VehicleModel { Id = 16, Name = "Ranger", Abrv = "RNG", MakeId = 2 },
    new VehicleModel { Id = 17, Name = "Fusion", Abrv = "FSN", MakeId = 2 },
    new VehicleModel { Id = 18, Name = "Transit", Abrv = "TRN", MakeId = 2 },
    new VehicleModel { Id = 19, Name = "Edge", Abrv = "EDG", MakeId = 2 },
    new VehicleModel { Id = 20, Name = "Fiesta", Abrv = "FST", MakeId = 2 },

    // Volkswagen (MakeId = 3)
    new VehicleModel { Id = 21, Name = "Golf", Abrv = "GLF", MakeId = 3 },
    new VehicleModel { Id = 22, Name = "Passat", Abrv = "PST", MakeId = 3 },
    new VehicleModel { Id = 23, Name = "Jetta", Abrv = "JTA", MakeId = 3 },
    new VehicleModel { Id = 24, Name = "Tiguan", Abrv = "TGN", MakeId = 3 },
    new VehicleModel { Id = 25, Name = "Polo", Abrv = "PLO", MakeId = 3 },
    new VehicleModel { Id = 26, Name = "Arteon", Abrv = "ARN", MakeId = 3 },
    new VehicleModel { Id = 27, Name = "Touareg", Abrv = "TRG", MakeId = 3 },
    new VehicleModel { Id = 28, Name = "Atlas", Abrv = "ALS", MakeId = 3 },
    new VehicleModel { Id = 29, Name = "Beetle", Abrv = "BTL", MakeId = 3 },
    new VehicleModel { Id = 30, Name = "Up!", Abrv = "UP", MakeId = 3 },

    // Audi (MakeId = 4)
    new VehicleModel { Id = 31, Name = "A3", Abrv = "A3", MakeId = 4 },
    new VehicleModel { Id = 32, Name = "A4", Abrv = "A4", MakeId = 4 },
    new VehicleModel { Id = 33, Name = "A6", Abrv = "A6", MakeId = 4 },
    new VehicleModel { Id = 34, Name = "Q3", Abrv = "Q3", MakeId = 4 },
    new VehicleModel { Id = 35, Name = "Q5", Abrv = "Q5", MakeId = 4 },
    new VehicleModel { Id = 36, Name = "Q7", Abrv = "Q7", MakeId = 4 },
    new VehicleModel { Id = 37, Name = "R8", Abrv = "R8", MakeId = 4 },
    new VehicleModel { Id = 38, Name = "TT", Abrv = "TT", MakeId = 4 },
    new VehicleModel { Id = 39, Name = "S3", Abrv = "S3", MakeId = 4 },
    new VehicleModel { Id = 40, Name = "RS6", Abrv = "RS6", MakeId = 4 },

    // Toyota (MakeId = 5)
    new VehicleModel { Id = 41, Name = "Corolla", Abrv = "CRL", MakeId = 5 },
    new VehicleModel { Id = 42, Name = "Camry", Abrv = "CMR", MakeId = 5 },
    new VehicleModel { Id = 43, Name = "RAV4", Abrv = "RV4", MakeId = 5 },
    new VehicleModel { Id = 44, Name = "Prius", Abrv = "PRS", MakeId = 5 },
    new VehicleModel { Id = 45, Name = "Highlander", Abrv = "HLD", MakeId = 5 },
    new VehicleModel { Id = 46, Name = "Tacoma", Abrv = "TCM", MakeId = 5 },
    new VehicleModel { Id = 47, Name = "Yaris", Abrv = "YRS", MakeId = 5 },
    new VehicleModel { Id = 48, Name = "C-HR", Abrv = "CHR", MakeId = 5 },
    new VehicleModel { Id = 49, Name = "Supra", Abrv = "SPR", MakeId = 5 },
    new VehicleModel { Id = 50, Name = "Land Cruiser", Abrv = "LCR", MakeId = 5 },

    // Honda (MakeId = 6)
    new VehicleModel { Id = 51, Name = "Civic", Abrv = "CVC", MakeId = 6 },
    new VehicleModel { Id = 52, Name = "Accord", Abrv = "ACD", MakeId = 6 },
    new VehicleModel { Id = 53, Name = "CR-V", Abrv = "CRV", MakeId = 6 },
    new VehicleModel { Id = 54, Name = "Pilot", Abrv = "PLT", MakeId = 6 },
    new VehicleModel { Id = 55, Name = "Odyssey", Abrv = "ODY", MakeId = 6 },
    new VehicleModel { Id = 56, Name = "Fit", Abrv = "FIT", MakeId = 6 },
    new VehicleModel { Id = 57, Name = "HR-V", Abrv = "HRV", MakeId = 6 },
    new VehicleModel { Id = 58, Name = "Insight", Abrv = "INS", MakeId = 6 },
    new VehicleModel { Id = 59, Name = "Ridgeline", Abrv = "RDL", MakeId = 6 },
    new VehicleModel { Id = 60, Name = "Clarity", Abrv = "CLR", MakeId = 6 },

    // Chevrolet (MakeId = 7)
    new VehicleModel { Id = 61, Name = "Camaro", Abrv = "CMR", MakeId = 7 },
    new VehicleModel { Id = 62, Name = "Silverado", Abrv = "SLV", MakeId = 7 },
    new VehicleModel { Id = 63, Name = "Corvette", Abrv = "CVT", MakeId = 7 },
 new VehicleModel { Id = 64, Name = "Equinox", Abrv = "EQX", MakeId = 7 },
    new VehicleModel { Id = 65, Name = "Malibu", Abrv = "MLB", MakeId = 7 },
    new VehicleModel { Id = 66, Name = "Traverse", Abrv = "TRV", MakeId = 7 },
    new VehicleModel { Id = 67, Name = "Suburban", Abrv = "SBN", MakeId = 7 },
    new VehicleModel { Id = 68, Name = "Blazer", Abrv = "BLZ", MakeId = 7 },
    new VehicleModel { Id = 69, Name = "Bolt", Abrv = "BOL", MakeId = 7 },
    new VehicleModel { Id = 70, Name = "Colorado", Abrv = "CLD", MakeId = 7 },

    // Mercedes (MakeId = 8)
    new VehicleModel { Id = 71, Name = "C-Class", Abrv = "CCL", MakeId = 8 },
    new VehicleModel { Id = 72, Name = "E-Class", Abrv = "ECL", MakeId = 8 },
    new VehicleModel { Id = 73, Name = "S-Class", Abrv = "SCL", MakeId = 8 },
    new VehicleModel { Id = 74, Name = "GLC", Abrv = "GLC", MakeId = 8 },
    new VehicleModel { Id = 75, Name = "GLE", Abrv = "GLE", MakeId = 8 },
    new VehicleModel { Id = 76, Name = "A-Class", Abrv = "ACL", MakeId = 8 },
    new VehicleModel { Id = 77, Name = "CLA", Abrv = "CLA", MakeId = 8 },
    new VehicleModel { Id = 78, Name = "G-Class", Abrv = "GCL", MakeId = 8 },
    new VehicleModel { Id = 79, Name = "SL", Abrv = "SL", MakeId = 8 },
    new VehicleModel { Id = 80, Name = "AMG GT", Abrv = "AGT", MakeId = 8 },

    // Kia (MakeId = 9)
    new VehicleModel { Id = 81, Name = "Sportage", Abrv = "SPT", MakeId = 9 },
    new VehicleModel { Id = 82, Name = "Sorento", Abrv = "SRT", MakeId = 9 },
    new VehicleModel { Id = 83, Name = "Optima", Abrv = "OPT", MakeId = 9 },
    new VehicleModel { Id = 84, Name = "Soul", Abrv = "SOL", MakeId = 9 },
    new VehicleModel { Id = 85, Name = "Forte", Abrv = "FOR", MakeId = 9 },
    new VehicleModel { Id = 86, Name = "Telluride", Abrv = "TLR", MakeId = 9 },
    new VehicleModel { Id = 87, Name = "Rio", Abrv = "RIO", MakeId = 9 },
    new VehicleModel { Id = 88, Name = "Stinger", Abrv = "STR", MakeId = 9 },
    new VehicleModel { Id = 89, Name = "Niro", Abrv = "NRO", MakeId = 9 },
    new VehicleModel { Id = 90, Name = "K5", Abrv = "K5", MakeId = 9 },

    // Nissan (MakeId = 10)
    new VehicleModel { Id = 91, Name = "Altima", Abrv = "ALT", MakeId = 10 },
    new VehicleModel { Id = 92, Name = "Rogue", Abrv = "ROG", MakeId = 10 },
    new VehicleModel { Id = 93, Name = "Sentra", Abrv = "SEN", MakeId = 10 },
    new VehicleModel { Id = 94, Name = "Pathfinder", Abrv = "PTH", MakeId = 10 },
    new VehicleModel { Id = 95, Name = "Murano", Abrv = "MUR", MakeId = 10 },
    new VehicleModel { Id = 96, Name = "Versa", Abrv = "VRS", MakeId = 10 },
    new VehicleModel { Id = 97, Name = "Titan", Abrv = "TTN", MakeId = 10 },
    new VehicleModel { Id = 98, Name = "Leaf", Abrv = "LEF", MakeId = 10 },
    new VehicleModel { Id = 99, Name = "Z", Abrv = "Z", MakeId = 10 },
    new VehicleModel { Id = 100, Name = "Kicks", Abrv = "KCK", MakeId = 10 }
);

        }
    }
}
