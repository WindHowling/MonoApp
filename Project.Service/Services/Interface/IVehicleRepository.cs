using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Project.Service.Models;
using Project.Service.Pagging;

namespace Project.Service.Services.Interface
{
    public interface IVehicleRepository
    {
        IQueryable<VehicleMake> QueryMakes();
        Task<VehicleMake?> GetMakeByIdAsync(int id);
        Task<bool> AddMakeAsync(VehicleMake make);
        Task<bool> UpdateMakeAsync(VehicleMake make);
        Task<bool> DeleteMakeAsync(int id);
        Task<PaginatedList<VehicleMake>> GetFilteredMakesAsync(string sortOrder, string searchString, int pageNumber, int pageSize);

        IQueryable<VehicleModel> QueryModels();
        Task<VehicleModel?> GetModelByIdAsync(int id);
        Task<bool> AddModelAsync(VehicleModel model);
        Task<bool> UpdateModelAsync(VehicleModel model);
        Task<bool> DeleteModelAsync(int id);
        Task<PaginatedList<VehicleModel>> GetFilteredModelsAsync(int? makeId, string sortOrder, string searchString, int pageNumber, int pageSize);
    }
}
