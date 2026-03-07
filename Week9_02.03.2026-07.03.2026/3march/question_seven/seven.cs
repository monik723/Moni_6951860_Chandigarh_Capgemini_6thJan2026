using System;
using System.Collections.Generic;
using System.Linq;

public interface IProduct
{
    string Name { get; set; }
    string Category { get; set; }
    int Stock { get; set; }
    int Price { get; set; }
}

public interface IInventory
{
    void AddProduct(IProduct product);
    void RemoveProduct(IProduct product);
    int CalculateTotalValue();
    List<IProduct> GetProductsByCategory(string category);
    List<IProduct> SearchProductsByName(string name);
}

public class Product : IProduct
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }
}

public class Inventory : IInventory
{
    List<IProduct> products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        products.Add(product);
    }

    public void RemoveProduct(IProduct product)
    {
        products.Remove(product);
    }

    public int CalculateTotalValue()
    {
        return products.Sum(p => p.Stock * p.Price);
    }

    public List<IProduct> GetProductsByCategory(string category)
    {
        return products.Where(p => p.Category == category).ToList();
    }

    public List<IProduct> SearchProductsByName(string name)
    {
        return products.Where(p => p.Name.Contains(name)).ToList();
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(new Product { Name = "Laptop", Category = "Electronics", Stock = 5, Price = 1000 });
        inventory.AddProduct(new Product { Name = "Phone", Category = "Electronics", Stock = 10, Price = 500 });
        inventory.AddProduct(new Product { Name = "Chair", Category = "Furniture", Stock = 7, Price = 150 });

        Console.WriteLine("Electronics:");
        foreach (var p in inventory.GetProductsByCategory("Electronics"))
            Console.WriteLine($"Product Name:{p.Name} Category:{p.Category}");

        Console.WriteLine("\nTotal Value: " + inventory.CalculateTotalValue());
    }
}