using AutoMapper;
using CarService.Models;

namespace CarService.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>();
        }
    }
}
