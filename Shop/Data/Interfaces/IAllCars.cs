using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetObjectCar(int carId);
    }
}
