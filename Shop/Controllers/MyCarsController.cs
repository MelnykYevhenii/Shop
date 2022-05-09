using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;

namespace Shop.Controllers
{
    public class MyCarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public MyCarsController(IAllCars iAllCars, ICarsCategory iCarsCategories)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategories;
        }
        public ViewResult MyCarsList()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
