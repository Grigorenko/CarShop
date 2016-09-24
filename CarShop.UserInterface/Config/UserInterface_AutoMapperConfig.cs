using AutoMapper;

namespace CarShop.UserInterface.Config
{
    public static class UserInterface_AutoMapperConfig
    {
        public static IMapper GetMapper()
        {
            IMapper mapper = CarShop.BusinessLogic.Config.BusinessLogic_AutoMapperConfig.GetMapper();

            return mapper;
        }
    }
}