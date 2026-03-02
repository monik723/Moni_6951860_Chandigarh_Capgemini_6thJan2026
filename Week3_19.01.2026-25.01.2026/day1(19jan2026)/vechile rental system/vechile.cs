using System;
using System.Collections.Generic;

namespace VehicleRentalSystem
{
    // parent class
    class Vehicle
    {
        // Encapsulation
        private int vehicleId;
        private string brand;
        protected double ratePerDay;
        protected bool isAvailable = true;

        public Vehicle(int id, string brand, double rate)
        {
            vehicleId = id;
            this.brand = brand;
            ratePerDay = rate;
        }

        public int GetId() => vehicleId;
        public bool IsAvailable() => isAvailable;

        public virtual string GetTypeName()
        {
            return "Vehicle";
        }

        public virtual double CalculateRent(int days)
        {
            return days * ratePerDay;
        }

        public void Rent()
        {
            isAvailable = false;
        }

        public void Return()
        {
            isAvailable = true;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{vehicleId} | {GetTypeName()} | {brand} | Rate/day: ₹{ratePerDay} | Available: {isAvailable}");
        }
    }

    // car
    class Car : Vehicle
    {
        public Car(int id, string brand, double rate) : base(id, brand, rate) { }

        public override string GetTypeName()
        {
            return "Car";
        }
    }

    // bike
    class Bike : Vehicle
    {
        public Bike(int id, string brand, double rate) : base(id, brand, rate) { }

        public override string GetTypeName()
        {
            return "Bike";
        }
    }

    // truck
    class Truck : Vehicle
    {
        public Truck(int id, string brand, double rate) : base(id, brand, rate) { }

        public override string GetTypeName()
        {
            return "Truck";
        }
    }

    // customer
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            CustomerId = id;
            Name = name;
        }
    }

    // rental transaction
    class RentalTransaction
    {
        private Customer customer;
        private Vehicle vehicle;
        private int days;
        private double totalAmount;

        public RentalTransaction(Customer c, Vehicle v, int days)
        {
            customer = c;
            vehicle = v;
            this.days = days;
            totalAmount = v.CalculateRent(days);
        }

        public void Display()
        {
            Console.WriteLine("\n--- RENTAL RECEIPT ---");
            Console.WriteLine("Customer: " + customer.Name);
            Console.WriteLine("Vehicle: " + vehicle.GetTypeName() + " (ID: " + vehicle.GetId() + ")");
            Console.WriteLine("Days: " + days);
            Console.WriteLine("Total Amount: ₹" + totalAmount);
        }
    }

    // main class
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<RentalTransaction> transactions = new List<RentalTransaction>();

            // Sample vehicles
            vehicles.Add(new Car(1, "Honda City", 2000));
            vehicles.Add(new Bike(2, "Yamaha", 500));
            vehicles.Add(new Truck(3, "Tata", 5000));

            Console.Write("Enter Customer ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            string cname = Console.ReadLine();
            Customer customer = new Customer(cid, cname);

            int choice;
            do
            {
                Console.WriteLine("\n--- VEHICLE RENTAL MENU ---");
                Console.WriteLine("1. View Vehicles");
                Console.WriteLine("2. Rent Vehicle");
                Console.WriteLine("3. Return Vehicle");
                Console.WriteLine("4. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (var v in vehicles)
                            v.Display();
                        break;

                    case 2:
                        Console.Write("Enter Vehicle ID to rent: ");
                        int rid = Convert.ToInt32(Console.ReadLine());

                        Vehicle rv = vehicles.Find(v => v.GetId() == rid);

                        if (rv != null && rv.IsAvailable())
                        {
                            Console.Write("Enter number of days: ");
                            int days = Convert.ToInt32(Console.ReadLine());

                            rv.Rent();
                            RentalTransaction rt = new RentalTransaction(customer, rv, days);
                            transactions.Add(rt);
                            rt.Display();
                        }
                        else
                        {
                            Console.WriteLine("Vehicle not available!");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Vehicle ID to return: ");
                        int retId = Convert.ToInt32(Console.ReadLine());

                        Vehicle retV = vehicles.Find(v => v.GetId() == retId);

                        if (retV != null && !retV.IsAvailable())
                        {
                            retV.Return();
                            Console.WriteLine("Vehicle returned successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid vehicle or already available!");
                        }
                        break;
                }

            } while (choice != 4);
        }
    }
}
