using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategories)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategories;
        }
        public ViewResult GoodsList()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
