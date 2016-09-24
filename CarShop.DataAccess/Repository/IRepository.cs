using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarShop.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> Get();
        T Get(int id);
        ICollection<T> GetByPredicate(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Add(T entity);
    }
}
