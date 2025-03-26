using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleModelSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Abrv", "MakeId", "Name" },
                values: new object[] { "3S", 1, "3 Series" });

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Abrv", "MakeId", "Name" },
                values: new object[] { "5S", 1, "5 Series" });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "Id", "Abrv", "MakeId", "Name" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Abrv", "MakeId", "Name" },
                values: new object[] { "MST", 2, "Mustang" });

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Abrv", "MakeId", "Name" },
                values: new object[] { "GLF", 3, "Golf" });
        }
    }
}
