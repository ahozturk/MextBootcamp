using SalesApp.Domain.Entities;

namespace SalesApp.Domain.Services;

public class CarService
{
    private static List<Car> cars = new();

    public void Add(Car car)
    {
        cars.Add(car);
    }

    public void PrintConsole()
    {
        foreach (var car in cars)
        {
            Console.WriteLine($"Model: {car.Model}");
        }
    }

    public List<Car> GetAll()
    {
        return cars;
    }

    public void Remove(Guid id)
    {
        foreach (var car in cars)
        {
            if (car.Id == id)
            {
                cars.Remove(car);
                break;
            }
        }
    }
}
