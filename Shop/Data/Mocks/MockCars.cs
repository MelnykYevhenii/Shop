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
                        Img = "https://cdn0.riastatic.com/photosnewr/auto/photo/tesla_model-s__429764855-620x415x70.jpg", 
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
                        Img = "https://cdn.riastatic.com/photosnew/auto/photo/bmw_m3__400924983f.jpg",
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
                        Img = "https://cdn.motor1.com/images/mgl/q3Qpv/s1/2019-audi-r8.webp",
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
                        Img = "https://cdn.motor1.com/images/mgl/gL004/s1/2021-mercedes-benz-s-class-exterior.jpg",
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
                        Img = "https://cdn.hevcars.com.ua/wp-content/uploads/2020/01/nissan-leaf-sv-plus-2020-exterior-hevcars-2.jpg",
                        Price = 20000,
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
