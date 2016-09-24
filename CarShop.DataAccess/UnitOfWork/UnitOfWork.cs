using CarShop.DataAccess.Context;
using CarShop.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarShop.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CarShopContext db;
        private Dictionary<Type, object> _repo;

        public UnitOfWork()
        {
            db = new CarShopContext();
            _repo = new Dictionary<Type, object>();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repo.Keys.Contains(typeof(TEntity)))
                return _repo[typeof(TEntity)] as IRepository<TEntity>;

            var repository = new Repository<TEntity>(db);
            _repo.Add(typeof(TEntity), repository);

            return repository;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
