using AutoMapper;
using BusinessLayer.Models;
using DataLayer.Models;

namespace BusinessLayer
{
    public class ServiceStationProfile : Profile
    {
        public ServiceStationProfile()
        {
            CreateMap<Car, CarDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Inspector, InspectorDTO>().ReverseMap();
            CreateMap<Owner, OwnerDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
