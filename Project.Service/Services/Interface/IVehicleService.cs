using System.Threading.Tasks;
using Project.Service.Models;
using Project.Service.Helper;
using Project.Service.Pagging;

namespace Project.Service.Services.Interface
{
    public interface IVehicleService
    {
        // Makes
        Task<PaginatedList<VehicleMake>> GetAllMakesAsync(int pageNumber = 1, int pageSize = 10);
        Task<VehicleMake?> GetMakeByIdAsync(int id);
        Task<ActionStatus> TryAddMakeAsync(VehicleMake make);
        Task<ActionStatus> TryUpdateMakeAsync(VehicleMake make);
        Task<ActionStatus> TryDeleteMakeAsync(int id);
        Task<PaginatedList<VehicleMake>> GetFilteredMakesAsync(string sortOrder, string searchString, int pageNumber, int pageSize);

        // Models
        Task<PaginatedList<VehicleModel>> GetAllModelsAsync(int pageNumber = 1, int pageSize = 10);
        Task<VehicleModel?> GetModelByIdAsync(int id);
        Task<ActionStatus> TryAddModelAsync(VehicleModel model);
        Task<ActionStatus> TryUpdateModelAsync(VehicleModel model);
        Task<ActionStatus> TryDeleteModelAsync(int id);
        Task<PaginatedList<VehicleModel>> GetFilteredModelsAsync(int? makeId, string sortOrder, string searchString, int pageNumber, int pageSize);
    }
}
