using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Services.Interface;

namespace WebApp.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repository;

        public VehicleService(IVehicleRepository repository)
        {
            _repository = repository;
        }

        // ---------- MAKES ----------
        public async Task<IEnumerable<VehicleMake>> GetAllMakesAsync()
        {
            return await _repository.GetAllMakesAsync();
        }

        public async Task<VehicleMake?> GetMakeByIdAsync(int id)
        {
            return await _repository.GetMakeByIdAsync(id);
        }

        public async Task AddMakeAsync(VehicleMake make)
        {
            await _repository.AddMakeAsync(make);
        }

        public async Task UpdateMakeAsync(VehicleMake make)
        {
            await _repository.UpdateMakeAsync(make);
        }

        public async Task DeleteMakeAsync(int id)
        {
            await _repository.DeleteMakeAsync(id);
        }

        public IQueryable<VehicleMake> GetMakeQuery()
        {
            return _repository.QueryMakes();
        }

        // ---------- MODELS ----------
        public IQueryable<VehicleModel> GetModelQuery()
        {
            return _repository.QueryModels();
        }

        public async Task<VehicleModel> GetModelByIdAsync(int id)
        {
            return await _repository.GetModelByIdAsync(id);
        }

        public async Task AddModelAsync(VehicleModel model)
        {
            await _repository.AddModelAsync(model);
        }

        public async Task UpdateModelAsync(VehicleModel model)
        {
            await _repository.UpdateModelAsync(model);
        }

        public async Task DeleteModelAsync(int id)
        {
            await _repository.DeleteModelAsync(id);
        }

        // Opcionalno (interface ocekuje):
        public async Task<List<VehicleMake>> GetAllModelsAsync()
        {
            return await _repository.GetAllMakesAsync() as List<VehicleMake>;
        }
    }
}
