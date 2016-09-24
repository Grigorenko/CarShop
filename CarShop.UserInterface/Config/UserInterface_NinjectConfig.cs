using AutoMapper;
using CarShop.BusinessLogic.Services.Implementation;
using CarShop.BusinessLogic.Services.Interfaces;
using Ninject;

namespace CarShop.UserInterface.Config
{
    public static class UserInterface_NinjectConfig
    {
        public static void ConfigNinject(IKernel kernel)
        {
            kernel.Bind<IMapper>().ToMethod(x => UserInterface.Config.UserInterface_AutoMapperConfig.GetMapper());
            kernel.Bind<ICarService>().To<CarService>();
        }
    }
}