using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehicleMakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abrv = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMakes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abrv = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleMakes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "VehicleMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "VehicleMakes",
                columns: new[] { "Id", "Abrv", "Name" },
                values: new object[,]
                {
                    { 1, "BMW", "BMW" },
                    { 2, "FRD", "Ford" },
                    { 3, "VW", "Volkswagen" },
                    { 4, "AUD", "Audi" },
                    { 5, "TYT", "Toyota" },
                    { 6, "HND", "Honda" },
                    { 7, "CHV", "Chevrolet" },
                    { 8, "MB", "Mercedes" },
                    { 9, "KIA", "Kia" },
                    { 10, "NSN", "Nissan" }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "Abrv", "MakeId", "Name" },
                values: new object[,]
                {
                    { 1, "X5", 1, "X5" },
                    { 2, "3S", 1, "3 Series" },
                    { 3, "5S", 1, "5 Series" },
                    { 4, "7S", 1, "7 Series" },
                    { 5, "M3", 1, "M3" },
                    { 6, "M5", 1, "M5" },
                    { 7, "X3", 1, "X3" },
                    { 8, "X6", 1, "X6" },
                    { 9, "Z4", 1, "Z4" },
                    { 10, "I8", 1, "i8" },
                    { 11, "MST", 2, "Mustang" },
                    { 12, "F15", 2, "F-150" },
                    { 13, "FCS", 2, "Focus" },
                    { 14, "ESC", 2, "Escape" },
                    { 15, "EXP", 2, "Explorer" },
                    { 16, "RNG", 2, "Ranger" },
                    { 17, "FSN", 2, "Fusion" },
                    { 18, "TRN", 2, "Transit" },
                    { 19, "EDG", 2, "Edge" },
                    { 20, "FST", 2, "Fiesta" },
                    { 21, "GLF", 3, "Golf" },
                    { 22, "PST", 3, "Passat" },
                    { 23, "JTA", 3, "Jetta" },
                    { 24, "TGN", 3, "Tiguan" },
                    { 25, "PLO", 3, "Polo" },
                    { 26, "ARN", 3, "Arteon" },
                    { 27, "TRG", 3, "Touareg" },
                    { 28, "ALS", 3, "Atlas" },
                    { 29, "BTL", 3, "Beetle" },
                    { 30, "UP", 3, "Up!" },
                    { 31, "A3", 4, "A3" },
                    { 32, "A4", 4, "A4" },
                    { 33, "A6", 4, "A6" },
                    { 34, "Q3", 4, "Q3" },
                    { 35, "Q5", 4, "Q5" },
                    { 36, "Q7", 4, "Q7" },
                    { 37, "R8", 4, "R8" },
                    { 38, "TT", 4, "TT" },
                    { 39, "S3", 4, "S3" },
                    { 40, "RS6", 4, "RS6" },
                    { 41, "CRL", 5, "Corolla" },
                    { 42, "CMR", 5, "Camry" },
                    { 43, "RV4", 5, "RAV4" },
                    { 44, "PRS", 5, "Prius" },
                    { 45, "HLD", 5, "Highlander" },
                    { 46, "TCM", 5, "Tacoma" },
                    { 47, "YRS", 5, "Yaris" },
                    { 48, "CHR", 5, "C-HR" },
                    { 49, "SPR", 5, "Supra" },
                    { 50, "LCR", 5, "Land Cruiser" },
                    { 51, "CVC", 6, "Civic" },
                    { 52, "ACD", 6, "Accord" },
                    { 53, "CRV", 6, "CR-V" },
                    { 54, "PLT", 6, "Pilot" },
                    { 55, "ODY", 6, "Odyssey" },
                    { 56, "FIT", 6, "Fit" },
                    { 57, "HRV", 6, "HR-V" },
                    { 58, "INS", 6, "Insight" },
                    { 59, "RDL", 6, "Ridgeline" },
                    { 60, "CLR", 6, "Clarity" },
                    { 61, "CMR", 7, "Camaro" },
                    { 62, "SLV", 7, "Silverado" },
                    { 63, "CVT", 7, "Corvette" },
                    { 64, "EQX", 7, "Equinox" },
                    { 65, "MLB", 7, "Malibu" },
                    { 66, "TRV", 7, "Traverse" },
                    { 67, "SBN", 7, "Suburban" },
                    { 68, "BLZ", 7, "Blazer" },
                    { 69, "BOL", 7, "Bolt" },
                    { 70, "CLD", 7, "Colorado" },
                    { 71, "CCL", 8, "C-Class" },
                    { 72, "ECL", 8, "E-Class" },
                    { 73, "SCL", 8, "S-Class" },
                    { 74, "GLC", 8, "GLC" },
                    { 75, "GLE", 8, "GLE" },
                    { 76, "ACL", 8, "A-Class" },
                    { 77, "CLA", 8, "CLA" },
                    { 78, "GCL", 8, "G-Class" },
                    { 79, "SL", 8, "SL" },
                    { 80, "AGT", 8, "AMG GT" },
                    { 81, "SPT", 9, "Sportage" },
                    { 82, "SRT", 9, "Sorento" },
                    { 83, "OPT", 9, "Optima" },
                    { 84, "SOL", 9, "Soul" },
                    { 85, "FOR", 9, "Forte" },
                    { 86, "TLR", 9, "Telluride" },
                    { 87, "RIO", 9, "Rio" },
                    { 88, "STR", 9, "Stinger" },
                    { 89, "NRO", 9, "Niro" },
                    { 90, "K5", 9, "K5" },
                    { 91, "ALT", 10, "Altima" },
                    { 92, "ROG", 10, "Rogue" },
                    { 93, "SEN", 10, "Sentra" },
                    { 94, "PTH", 10, "Pathfinder" },
                    { 95, "MUR", 10, "Murano" },
                    { 96, "VRS", 10, "Versa" },
                    { 97, "TTN", 10, "Titan" },
                    { 98, "LEF", 10, "Leaf" },
                    { 99, "Z", 10, "Z" },
                    { 100, "KCK", 10, "Kicks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_MakeId",
                table: "VehicleModels",
                column: "MakeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "VehicleMakes");
        }
    }
}
