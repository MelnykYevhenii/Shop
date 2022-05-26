using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _content;

        public  CarRepository(AppDBContent appDbContent){
            this._content = appDbContent;
        }
        public IEnumerable<Car> Cars => _content.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => _content.Car.Where(x => x.IsFavorite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => _content.Car.FirstOrDefault(x => x.Id == carId);
    }
}
