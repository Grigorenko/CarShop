using AutoMapper;
using CarShop.BusinessLogic.DTO;
using CarShop.Models;

namespace CarShop.BusinessLogic.Config
{
    public static class BusinessLogic_AutoMapperConfig
    {
        public static IMapper GetMapper()
        {
            MapperConfiguration config = new MapperConfiguration(exp => {
                //TODO create map rule here
                exp.CreateMap<Car, CarDTO>();
                exp.CreateMap<CarDTO, Car>();
            });

            return config.CreateMapper();
        }
    }
}
