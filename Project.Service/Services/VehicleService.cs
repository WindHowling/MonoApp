using System.Threading.Tasks;
using Project.Service.Helper;
using Project.Service.Models;
using Project.Service.Pagging;
using Project.Service.Services.Interface;

namespace Project.Service.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repository;

        public VehicleService(IVehicleRepository repository)
        {
            _repository = repository;
        }

        // Makes
        public async Task<PaginatedList<VehicleMake>> GetAllMakesAsync(int pageNumber = 1, int pageSize = 10)
        {
            return await PaginatedList<VehicleMake>.CreateAsync(_repository.QueryMakes(), pageNumber, pageSize);
        }

        public Task<VehicleMake?> GetMakeByIdAsync(int id) => _repository.GetMakeByIdAsync(id);

        public async Task<ActionStatus> TryAddMakeAsync(VehicleMake make)
        {
            var result = await _repository.AddMakeAsync(make);
            return result ? ActionStatus.Success() : ActionStatus.Failure("Dodavanje marke nije uspjelo.");
        }

        public async Task<ActionStatus> TryUpdateMakeAsync(VehicleMake make)
        {
            var exists = await _repository.GetMakeByIdAsync(make.Id);
            if (exists == null)
                return ActionStatus.Failure("Marka ne postoji.");

            var result = await _repository.UpdateMakeAsync(make);
            return result ? ActionStatus.Success() : ActionStatus.Failure("Ažuriranje marke nije uspjelo.");
        }

        public async Task<ActionStatus> TryDeleteMakeAsync(int id)
        {
            var result = await _repository.DeleteMakeAsync(id);
            return result ? ActionStatus.Success() : ActionStatus.Failure("Brisanje marke nije uspjelo.");
        }

        public Task<PaginatedList<VehicleMake>> GetFilteredMakesAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            return _repository.GetFilteredMakesAsync(sortOrder, searchString, pageNumber, pageSize);
        }

        // Models
        public async Task<PaginatedList<VehicleModel>> GetAllModelsAsync(int pageNumber = 1, int pageSize = 10)
        {
            return await PaginatedList<VehicleModel>.CreateAsync(_repository.QueryModels(), pageNumber, pageSize);
        }

        public Task<VehicleModel?> GetModelByIdAsync(int id) => _repository.GetModelByIdAsync(id);

        public async Task<ActionStatus> TryAddModelAsync(VehicleModel model)
        {
            var result = await _repository.AddModelAsync(model);
            return result ? ActionStatus.Success() : ActionStatus.Failure("Dodavanje modela nije uspjelo.");
        }

        public async Task<ActionStatus> TryUpdateModelAsync(VehicleModel model)
        {
            var exists = await _repository.GetModelByIdAsync(model.Id);
            if (exists == null)
                return ActionStatus.Failure("Model ne postoji.");

            var result = await _repository.UpdateModelAsync(model);
            return result ? ActionStatus.Success() : ActionStatus.Failure("Ažuriranje modela nije uspjelo.");
        }

        public async Task<ActionStatus> TryDeleteModelAsync(int id)
        {
            var result = await _repository.DeleteModelAsync(id);
            return result ? ActionStatus.Success() : ActionStatus.Failure("Brisanje modela nije uspjelo.");
        }

        public Task<PaginatedList<VehicleModel>> GetFilteredModelsAsync(int? makeId, string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            return _repository.GetFilteredModelsAsync(makeId, sortOrder, searchString, pageNumber, pageSize);
        }
    }
}
