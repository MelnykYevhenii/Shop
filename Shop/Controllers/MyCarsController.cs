using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
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
        [Route("MyCars/MyCarsList")]
        [Route("MyCars/MyCarsList/{category}")]
        public ViewResult MyCarsList(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(x => x.Id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(x => x.Category.CategoryName.Equals("Електромобілі")).OrderBy(i => i.Id);
                    currCategory = "Електромобілі";
                }
                else
                {
                    cars = _allCars.Cars.Where(x => !x.Category.CategoryName.Equals("Електромобілі"));
                    currCategory = "Класничні авто";
                }
                //currCategory = _category;
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };
            ViewBag.Title = "Сторінка з авто";
            return View(carObj);
        }
    }
}
