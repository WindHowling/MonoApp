using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<VehicleMake>> GetAllModelsAsync()
        {
            return await _repository.GetAllMakesAsync() as List<VehicleMake>;
        }
        public async Task<PaginatedList<VehicleMake>> GetAllMakesPagedAsync(int pageNumber, int pageSize)
        {
            var query = _repository.QueryMakes();
            return await PaginatedList<VehicleMake>.CreateAsync(query, pageNumber, pageSize);
        }

        public async Task<ActionStatus> TryAddMakeAsync(VehicleMake make)
        {
            try
            {
                await _repository.AddMakeAsync(make);
                return ActionStatus.Success();
            }
            catch (Exception ex)
            {
                return ActionStatus.Failure($"Failed to add make: {ex.Message}");
            }
        }

        public async Task<ActionStatus> TryUpdateMakeAsync(VehicleMake make)
        {
            try
            {
                await _repository.UpdateMakeAsync(make);
                return ActionStatus.Success();
            }
            catch (Exception ex)
            {
                return ActionStatus.Failure($"Failed to update make: {ex.Message}");
            }
        }

        public async Task<ActionStatus> TryDeleteMakeAsync(int id)
        {
            try
            {
                await _repository.DeleteMakeAsync(id);
                return ActionStatus.Success();
            }
            catch (Exception ex)
            {
                return ActionStatus.Failure($"Failed to delete make: {ex.Message}");
            }
        }

        public async Task<ActionStatus> TryAddModelAsync(VehicleModel model)
        {
            try
            {
                await _repository.AddModelAsync(model);
                return ActionStatus.Success();
            }
            catch (Exception ex)
            {
                return ActionStatus.Failure($"Failed to add model: {ex.Message}");
            }
        }

        public async Task<ActionStatus> TryUpdateModelAsync(VehicleModel model)
        {
            try
            {
                await _repository.UpdateModelAsync(model);
                return ActionStatus.Success();
            }
            catch (Exception ex)
            {
                return ActionStatus.Failure($"Failed to update model: {ex.Message}");
            }
        }

        public async Task<ActionStatus> TryDeleteModelAsync(int id)
        {
            try
            {
                await _repository.DeleteModelAsync(id);
                return ActionStatus.Success();
            }
            catch (Exception ex)
            {
                return ActionStatus.Failure($"Failed to delete model: {ex.Message}");
            }
        }

        public async Task<PaginatedList<VehicleMake>> GetFilteredMakesAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            var query = _repository.QueryMakes();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.Name.Contains(searchString) || m.Abrv.Contains(searchString));
            }

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(m => m.Name),
                "abrv" => query.OrderBy(m => m.Abrv),
                "abrv_desc" => query.OrderByDescending(m => m.Abrv),
                _ => query.OrderBy(m => m.Name)
            };

            return await PaginatedList<VehicleMake>.CreateAsync(query, pageNumber, pageSize);
        }

        public async Task<PaginatedList<VehicleModel>> GetFilteredModelsAsync(int? makeId, string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            var query = _repository.QueryModels();

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

