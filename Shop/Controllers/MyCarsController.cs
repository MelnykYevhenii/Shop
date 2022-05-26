using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

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
            ViewBag.Title = "Сторінка з авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Авто";
            return View(obj);
        }
    }
}
