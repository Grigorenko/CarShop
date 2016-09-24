using CarShop.DataAccess.Repository;

namespace CarShop.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void Save();
    }
}
