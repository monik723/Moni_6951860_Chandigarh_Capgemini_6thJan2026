using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Name;
    public double Price;
    public int Stock;

    public Book(string n, double p, int s)
    {
        Name = n;
        Price = p;
        Stock = s;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>()
        {
            new Book("C# Basics", 500, 5),
            new Book("Java", 300, 0),
            new Book("Python", 400, 3)
        };

        // 1. Add new book
        books.Add(new Book("AI", 350, 4));

        // 2. Find books cheaper than 400
        var cheapBooks = books.Where(b => b.Price < 400).ToList();

        Console.WriteLine("Books cheaper than 400:");
        foreach (var b in cheapBooks)
            Console.WriteLine(b.Name + " - " + b.Price);

        // 3. Increase price by 10%
        books.ForEach(b => b.Price = b.Price * 1.10);

        // 4. Remove out-of-stock books
        books.RemoveAll(b => b.Stock == 0);

        Console.WriteLine("\nFinal Book List:");
        foreach (var b in books)
            Console.WriteLine(b.Name + " - " + b.Price + " - Stock: " + b.Stock);
    }
}
