using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Service.Database;
using Project.Service.Models;
using Project.Service.Pagging;
using Project.Service.Services.Interface;
using System;

namespace Project.Service.Services
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleDbContext _context;

        public VehicleRepository(VehicleDbContext context)
        {
            _context = context;
        }

        // Makes
        public IQueryable<VehicleMake> QueryMakes() => _context.VehicleMakes;

        public async Task<VehicleMake?> GetMakeByIdAsync(int id) =>
            await _context.VehicleMakes.FindAsync(id);

        public async Task<bool> AddMakeAsync(VehicleMake make)
        {
            try
            {
                await _context.VehicleMakes.AddAsync(make);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateMakeAsync(VehicleMake make)
        {
            try
            {
                _context.VehicleMakes.Update(make);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteMakeAsync(int id)
        {
            try
            {
                var make = await GetMakeByIdAsync(id);
                if (make == null) return false;

                _context.VehicleMakes.Remove(make);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<PaginatedList<VehicleMake>> GetFilteredMakesAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            var query = _context.VehicleMakes.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
                query = query.Where(m => m.Name.Contains(searchString) || m.Abrv.Contains(searchString));

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(m => m.Name),
                "abrv" => query.OrderBy(m => m.Abrv),
                "abrv_desc" => query.OrderByDescending(m => m.Abrv),
                _ => query.OrderBy(m => m.Name)
            };

            return await PaginatedList<VehicleMake>.CreateAsync(query, pageNumber, pageSize);
        }

        // Models
        public IQueryable<VehicleModel> QueryModels() => _context.VehicleModels;

        public async Task<VehicleModel?> GetModelByIdAsync(int id) =>
            await _context.VehicleModels.FindAsync(id);

        public async Task<bool> AddModelAsync(VehicleModel model)
        {
            try
            {
                await _context.VehicleModels.AddAsync(model);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateModelAsync(VehicleModel model)
        {
            try
            {
                _context.VehicleModels.Update(model);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteModelAsync(int id)
        {
            try
            {
                var model = await GetModelByIdAsync(id);
                if (model == null) return false;

                _context.VehicleModels.Remove(model);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<PaginatedList<VehicleModel>> GetFilteredModelsAsync(int? makeId, string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            var query = _context.VehicleModels.AsQueryable();

            if (makeId.HasValue)
                query = query.Where(m => m.MakeId == makeId.Value);

            if (!string.IsNullOrEmpty(searchString))
                query = query.Where(m => m.Name.Contains(searchString) || m.Abrv.Contains(searchString));

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(m => m.Name),
                "abrv" => query.OrderBy(m => m.Abrv),
                "abrv_desc" => query.OrderByDescending(m => m.Abrv),
                _ => query.OrderBy(m => m.Name)
            };

            return await PaginatedList<VehicleModel>.CreateAsync(query, pageNumber, pageSize);
        }
    }
}
