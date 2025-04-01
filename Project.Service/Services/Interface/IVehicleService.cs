using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Service.Helper;
using Project.Service.Models;
using Project.Service.Pagging;

namespace Project.Service.Services.Interface
{
    public interface IVehicleService
    {
        // Vehicle Makes
        Task<PaginatedList<VehicleMake>> GetAllMakesAsync(int pageNumber = 1, int pageSize = 10);
        Task<VehicleMake?> GetMakeByIdAsync(int id);
        Task AddMakeAsync(VehicleMake make);
        Task UpdateMakeAsync(VehicleMake make);
        Task DeleteMakeAsync(int id);
        IQueryable<VehicleMake> GetMakeQuery();

        // Vehicle Models
        Task<PaginatedList<VehicleModel>> GetAllModelsAsync(int pageNumber = 1, int pageSize = 10);
        Task<VehicleModel> GetModelByIdAsync(int id);
        Task AddModelAsync(VehicleModel model);
        Task UpdateModelAsync(VehicleModel model);
        Task DeleteModelAsync(int id);
        IQueryable<VehicleModel> GetModelQuery();

        // Safe actions
        Task<ActionStatus> TryAddMakeAsync(VehicleMake make);
        Task<ActionStatus> TryUpdateMakeAsync(VehicleMake make);
        Task<ActionStatus> TryDeleteMakeAsync(int id);
        Task<ActionStatus> TryAddModelAsync(VehicleModel model);
        Task<ActionStatus> TryUpdateModelAsync(VehicleModel model);
        Task<ActionStatus> TryDeleteModelAsync(int id);

        // Filtered results
        Task<PaginatedList<VehicleMake>> GetFilteredMakesAsync(string sortOrder, string searchString, int pageNumber, int pageSize);
        Task<PaginatedList<VehicleModel>> GetFilteredModelsAsync(int? makeId, string sortOrder, string searchString, int pageNumber, int pageSize);
    }
}
