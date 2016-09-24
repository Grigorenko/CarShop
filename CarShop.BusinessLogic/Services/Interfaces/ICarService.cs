using CarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarShop.BusinessLogic.Services.Interfaces
{
    public interface ICarService
    {
        void Add(Car car);
        Car Get(int id);
        ICollection<Car> Get();
        ICollection<Car> GetByPredicate(Expression<Func<Car, bool>> predicate);
        void Delete(int id);
        void Delete(Car car);
        void Update(Car car);
    }
}
