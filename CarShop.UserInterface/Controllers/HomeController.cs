using CarShop.BusinessLogic.Services.Implementation;
using CarShop.BusinessLogic.Services.Interfaces;
using CarShop.DataAccess.Context;
using CarShop.DataAccess.UnitOfWork;
using CarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarShop.UserInterface.Controllers
{
    public class HomeController : ApiController
    {
        //ICarService serv;
        //public HomeController()
        //{
        //    serv = new CarService(new UnitOfWork(new CarShopContext()));
        //}

        [HttpGet]
        public ICollection<Car> Get()
        {
            IUnitOfWork unit = new UnitOfWork(new CarShopContext());

            return unit.GetRepository<Car>().Get();
        }
    }
}
