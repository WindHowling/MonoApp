using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Project.Service.Database
{
    public class VehicleDbContextFactory : IDesignTimeDbContextFactory<VehicleDbContext>
    {
        public VehicleDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VehicleDbContext>();
            var connectionString = "server=localhost;port=3306;database=VehicleDB;user=vehicleapp;password=Stipetin0517;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new VehicleDbContext(optionsBuilder.Options);
        }
    }
}
