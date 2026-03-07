using System;
using System.Collections.Generic;
using System.Linq;

interface ICategory
{
    int Id { get; set; }
    string Name { get; set; }
    List<IProduct> Products { get; set; }
    void AddProduct(IProduct product);
}

interface IProduct
{
    int Id { get; set; }
    string Name { get; set; }
    decimal Price { get; set; }
}

interface ICompany
{
    string GetTopCategoryNameByProductCount();
    List<IProduct> GetProductsBelongsToMultipleCategory();
    (string categoryName, decimal totalValue) GetTopCategoryBySumOfProductPrices();
    List<(ICategory category, decimal totalValue)> GetCategoriesWithSumOfTheProductPrices();
}

class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class Category : ICategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<IProduct> Products { get; set; } = new List<IProduct>();

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddProduct(IProduct product)
    {
        Products.Add(product);
    }
}

class Company : ICompany
{
    public int Id;
    public string Name;
    List<ICategory> categories = new List<ICategory>();

    public Company(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddCategory(ICategory c)
    {
        categories.Add(c);
    }

    public string GetTopCategoryNameByProductCount()
    {
        return categories.OrderByDescending(x => x.Products.Count)
                         .First().Name;
    }

    public List<IProduct> GetProductsBelongsToMultipleCategory()
    {
        return categories.SelectMany(x => x.Products)
            .GroupBy(p => p.Id)
            .Where(g => g.Count() > 1)
            .Select(g => g.First())
            .ToList();
    }

    public (string categoryName, decimal totalValue) GetTopCategoryBySumOfProductPrices()
    {
        var cat = categories
            .Select(c => new { c.Name, Total = c.Products.Sum(p => p.Price) })
            .OrderByDescending(x => x.Total)
            .First();

        return (cat.Name, cat.Total);
    }

    public List<(ICategory category, decimal totalValue)> GetCategoriesWithSumOfTheProductPrices()
    {
        return categories
            .Select(c => (c, c.Products.Sum(p => p.Price)))
            .ToList();
    }
}

class Program
{
    static void Main()
    {
        var company = new Company(1, "Shop");

        var p1 = new Product(1, "Laptop", 1000);
        var p2 = new Product(2, "Phone", 700);
        var p3 = new Product(3, "Chair", 150);

        var c1 = new Category(1, "Electronics");
        var c2 = new Category(2, "Furniture");

        c1.AddProduct(p1);
        c1.AddProduct(p2);

        c2.AddProduct(p3);
        c2.AddProduct(p1);

        company.AddCategory(c1);
        company.AddCategory(c2);

        Console.WriteLine("Top category:" + company.GetTopCategoryNameByProductCount());

        Console.WriteLine("Common products:");
        foreach (var p in company.GetProductsBelongsToMultipleCategory())
            Console.WriteLine(p.Name);

        var top = company.GetTopCategoryBySumOfProductPrices();
        Console.WriteLine("Most valuable category:" + top.categoryName + " " + top.totalValue);

        foreach (var x in company.GetCategoriesWithSumOfTheProductPrices())
            Console.WriteLine(x.category.Name + " " + x.totalValue);
    }
}