using AutoMapper;
using Project.Service.Models;
using Project.MVC.ViewModels;

namespace Project.MVC.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // EF Models → ViewModels
            CreateMap<VehicleMake, VehicleMakeViewModel>().ReverseMap();
            CreateMap<VehicleModel, VehicleModelViewModel>().ReverseMap();
        }
    }
}
