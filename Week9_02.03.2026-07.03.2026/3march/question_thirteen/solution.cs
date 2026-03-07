using System;
using System.Collections.Generic;
using System.Linq;

interface ICar
{
    int Id { get; set; }
    string Brand { get; set; }
    string Model { get; set; }
    decimal Price { get; set; }
}

interface ICarManagement
{
    void AddCar(ICar car);
    void RemoveCar(int id);
    List<ICar> GetCarsByBrand(string brand);
    decimal GetTotalValue();
}

class Car : ICar
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
}

class CarManagement : ICarManagement
{
    List<ICar> cars = new List<ICar>();

    public void AddCar(ICar car)
    {
        cars.Add(car);
    }

    public void RemoveCar(int id)
    {
        var car = cars.FirstOrDefault(x => x.Id == id);
        if (car != null)
            cars.Remove(car);
    }

    public List<ICar> GetCarsByBrand(string brand)
    {
        return cars.Where(c => c.Brand == brand).ToList();
    }

    public decimal GetTotalValue()
    {
        return cars.Sum(c => c.Price);
    }
}

class Program
{
    static void Main()
    {
        ICarManagement manager = new CarManagement();

        manager.AddCar(new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Price = 20000 });
        manager.AddCar(new Car { Id = 2, Brand = "BMW", Model = "X5", Price = 50000 });
        manager.AddCar(new Car { Id = 3, Brand = "Toyota", Model = "Camry", Price = 30000 });

        Console.WriteLine("Toyota Cars:");
        foreach (var car in manager.GetCarsByBrand("Toyota"))
        {
            Console.WriteLine($"{car.Brand} {car.Model} ${car.Price}");
        }

        Console.WriteLine("Total Value: $" + manager.GetTotalValue());
    }
}