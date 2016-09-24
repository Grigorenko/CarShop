using CarShop.BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using CarShop.Models;
using System.Linq.Expressions;
using CarShop.DataAccess.UnitOfWork;

namespace CarShop.BusinessLogic.Services.Implementation
{
    public class CarService : ICarService
    {
        private IUnitOfWork _unit;
        public CarService(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public void Add(Car car)
        {
            _unit.GetRepository<Car>().Add(car);
        }

        public void Delete(Car car)
        {
            _unit.GetRepository<Car>().Delete(car);
        }

        public void Delete(int id)
        {
            _unit.GetRepository<Car>().Delete(id);
        }

        public ICollection<Car> Get()
        {
            return _unit.GetRepository<Car>().Get();
        }

        public Car Get(int id)
        {
            return _unit.GetRepository<Car>().Get(id);
        }

        public ICollection<Car> GetByPredicate(Expression<Func<Car, bool>> predicate)
        {
            return _unit.GetRepository<Car>().GetByPredicate(predicate);
        }

        public void Update(Car car)
        {
            _unit.GetRepository<Car>().Update(car);
        }
    }
}
