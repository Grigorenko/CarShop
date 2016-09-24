using CarShop.BusinessLogic.Services.Implementation;
using CarShop.BusinessLogic.Services.Interfaces;
using CarShop.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CarShop.UserInterface.Controllers
{
    public class HomeController : ApiController
    {
        ICarService serv;

        public HomeController()
        {
            serv = new CarService();
        }

        [HttpGet]
        public ICollection<Car> Get()
        {
            return serv.Get();
        }

        [HttpPost]
        public void Add(Car car)
        {
            var cars = car;
            //serv.Add(car);
        }
    }
}
