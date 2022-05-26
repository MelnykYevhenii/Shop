using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    { 
                        Name = "Tesla Model S", 
                        ShortDesc = "ShortDesc", 
                        LongDesc = "LongDesc", 
                        Img = "/img/tesla.jpg", 
                        Price = 45000, 
                        IsFavorite = true, 
                        Available = true, 
                        Category = _carsCategory.AllCategories.First() 
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "ShortDesc",
                        LongDesc = "LongDesc",
                        Img = "/img/bmw.jpg",
                        Price = 35000,
                        IsFavorite = true,
                        Available = false,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Audi",
                        ShortDesc = "ShortDesc",
                        LongDesc = "LongDesc",
                        Img = "/img/audi.jpg",
                        Price = 65000,
                        IsFavorite = false,
                        Available = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Mercedes S Class",
                        ShortDesc = "ShortDesc",
                        LongDesc = "LongDesc",
                        Img = "/img/mercedes.jpg",
                        Price = 60000,
                        IsFavorite = false,
                        Available = false,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "ShortDesc",
                        LongDesc = "LongDesc",
                        Img = "/img/nissan.jpg",
                        Price = 20000,
                        IsFavorite = false,
                        Available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Renault Megane",
                        ShortDesc = "ShortDesc",
                        LongDesc = "LongDesc",
                        Img = "/img/megane.jpg",
                        Price = 25000,
                        IsFavorite = false,
                        Available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
