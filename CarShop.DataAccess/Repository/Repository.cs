using CarShop.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CarShop.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CarShopContext db;
        private DbSet<T> dbSet;

        public Repository(CarShopContext con)
        {
            db = con;
            dbSet = db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public ICollection<T> Get()
        {
            return dbSet.ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public ICollection<T> GetByPredicate(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate).ToList();
        }

        public void Update(T entity)
        {
            //db.Entry(entity).State = EntityState.Modified;
        }
    }
}
