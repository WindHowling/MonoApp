using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Project.Service.Models;

namespace Project.Service.Services.Interface
{
    public interface IVehicleRepository
    {
        //Vehicle Makes
        IQueryable<VehicleMake> QueryMakes();
        Task<List<VehicleMake>> GetAllMakesAsync();
        Task<VehicleMake?> GetMakeByIdAsync(int id);
        Task AddMakeAsync(VehicleMake make);
        Task UpdateMakeAsync(VehicleMake make);
        Task DeleteMakeAsync(int id);

        //Vehicle Models
        IQueryable<VehicleModel> QueryModels();
        Task<VehicleModel?> GetModelByIdAsync(int id);
        Task AddModelAsync(VehicleModel model);
        Task UpdateModelAsync(VehicleModel model);
        Task DeleteModelAsync(int id);
    }
}
