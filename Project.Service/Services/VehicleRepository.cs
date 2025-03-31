using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Service.Database;
using Project.Service.Models;
using Project.Service.Services.Interface;

namespace Project.Service.Services
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleDbContext _context;

        public VehicleRepository(VehicleDbContext context)
        {
            _context = context;
        }

        //Makes
        public IQueryable<VehicleMake> QueryMakes()
        {
            return _context.VehicleMakes.AsQueryable();
        }

        public async Task<List<VehicleMake>> GetAllMakesAsync()
        {
            return await _context.VehicleMakes.ToListAsync();
        }

        public async Task<VehicleMake?> GetMakeByIdAsync(int id)
        {
            return await _context.VehicleMakes.FindAsync(id);
        }

        public async Task AddMakeAsync(VehicleMake make)
        {
            await _context.VehicleMakes.AddAsync(make);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMakeAsync(VehicleMake make)
        {
            _context.VehicleMakes.Update(make);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMakeAsync(int id)
        {
            var make = await _context.VehicleMakes.FindAsync(id);
            if (make != null)
            {
                _context.VehicleMakes.Remove(make);
                await _context.SaveChangesAsync();
            }
        }

        //Models
        public IQueryable<VehicleModel> QueryModels()
        {
            return _context.VehicleModels.AsQueryable();
        }

        public async Task<VehicleModel?> GetModelByIdAsync(int id)
        {
            return await _context.VehicleModels.FindAsync(id);
        }

        public async Task AddModelAsync(VehicleModel model)
        {
            await _context.VehicleModels.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateModelAsync(VehicleModel model)
        {
            _context.VehicleModels.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteModelAsync(int id)
        {
            var model = await _context.VehicleModels.FindAsync(id);
            if (model != null)
            {
                _context.VehicleModels.Remove(model);
                await _context.SaveChangesAsync();
            }
        }
    }
}
