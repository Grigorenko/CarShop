using CarShop.DataAccess.UnitOfWork;
using Ninject;

namespace CarShop.BusinessLogic.Config
{
    public static class BusinessLogic_NinjectConfig
    {
        public static void ConfigNinject(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
