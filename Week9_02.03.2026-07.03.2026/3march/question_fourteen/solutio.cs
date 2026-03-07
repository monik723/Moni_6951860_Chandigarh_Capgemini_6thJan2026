using System;

abstract class Car
{
    protected string brand;
    protected string model;

    public Car(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

    public abstract string GetInfo();
}

class ElectricCar : Car
{
    public ElectricCar(string brand, string model)
        : base(brand, model) { }

    public override string GetInfo()
    {
        return $"Electric Car: {brand} {model}";
    }
}

class GasCar : Car
{
    public GasCar(string brand, string model)
        : base(brand, model) { }

    public override string GetInfo()
    {
        return $"Gas Car: {brand} {model}";
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new ElectricCar("Tesla", "Model 3");
        Car car2 = new GasCar("Toyota", "Corolla");

        Console.WriteLine(car1.GetInfo());
        Console.WriteLine(car2.GetInfo());
    }
}