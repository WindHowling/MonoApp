using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Pagging;
using WebApp.ViewModels;

namespace WebApp.Services.Interface
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleMake>> GetAllMakesAsync();
        Task<VehicleMake?> GetMakeByIdAsync(int id);
        Task AddMakeAsync(VehicleMake make);
        Task UpdateMakeAsync(VehicleMake make);
        Task DeleteMakeAsync(int id);
        IQueryable<VehicleMake> GetMakeQuery();

        IQueryable<VehicleModel> GetModelQuery();
        Task<VehicleModel> GetModelByIdAsync(int id);
        Task AddModelAsync(VehicleModel model);
        Task UpdateModelAsync(VehicleModel model);
        Task DeleteModelAsync(int id);
        Task<List<VehicleMake>> GetAllModelsAsync();


    }
}
