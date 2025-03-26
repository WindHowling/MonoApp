using AutoMapper;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // EF -> ViewModel
            CreateMap<VehicleMake, VehicleMakeViewModel>();
            CreateMap<VehicleModel, VehicleModelViewModel>();

            // ViewModel -> EF
            CreateMap<VehicleMakeViewModel, VehicleMake>();
            CreateMap<VehicleModelViewModel, VehicleModel>();
        }
    }
}
