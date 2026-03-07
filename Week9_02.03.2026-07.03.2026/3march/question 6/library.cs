using System;
using System.Collections.Generic;
using System.Linq;

public interface IBook
{
    int Id { get; set; }
    string Title { get; set; }
    string Author { get; set; }
    string Category { get; set; }
    int Price { get; set; }
}

public interface ILibrarySystem
{
    void AddBook(IBook book, int quantity);
    void RemoveBook(IBook book, int quantity);
    int CalculateTotal();
    List<(string, int)> CategoryTotalPrice();
    List<(string, int, int)> BooksInfo();
    List<(string, string, int)> CategoryAndAuthorWithCount();
}

public class Book : IBook
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }
}

public class LibrarySystem : ILibrarySystem
{
    Dictionary<IBook, int> books = new Dictionary<IBook, int>();

    public void AddBook(IBook book, int quantity)
    {
        books[book] = quantity;
    }

    public void RemoveBook(IBook book, int quantity)
    {
        if (books.ContainsKey(book))
            books[book] -= quantity;
    }

    public int CalculateTotal()
    {
        return books.Sum(x => x.Key.Price * x.Value);
    }

    public List<(string, int)> CategoryTotalPrice()
    {
        return books.GroupBy(x => x.Key.Category)
            .Select(g => (g.Key, g.Sum(x => x.Key.Price * x.Value))).ToList();
    }

    public List<(string, int, int)> BooksInfo()
    {
        return books.Select(x => (x.Key.Title, x.Value, x.Key.Price)).ToList();
    }

    public List<(string, string, int)> CategoryAndAuthorWithCount()
    {
        return books.GroupBy(x => new { x.Key.Category, x.Key.Author })
            .Select(g => (g.Key.Category, g.Key.Author, g.Sum(x => x.Value))).ToList();
    }
}

class Program
{
    static void Main()
    {
        ILibrarySystem library = new LibrarySystem();

        IBook b1 = new Book { Id = 1, Title = "CSharp", Author = "John", Category = "Programming", Price = 100 };
        IBook b2 = new Book { Id = 2, Title = "Java", Author = "Mike", Category = "Programming", Price = 120 };
        IBook b3 = new Book { Id = 3, Title = "History", Author = "Anne", Category = "Education", Price = 90 };

        library.AddBook(b1, 2);
        library.AddBook(b2, 3);
        library.AddBook(b3, 1);

        Console.WriteLine("Book Info:");
        foreach (var b in library.BooksInfo())
            Console.WriteLine($"Book Name:{b.Item1}, Quantity:{b.Item2}, Price:{b.Item3}");

        Console.WriteLine("\nCategory Total Price:");
        foreach (var c in library.CategoryTotalPrice())
            Console.WriteLine($"Category:{c.Item1}, Total Price:{c.Item2}");

        Console.WriteLine("\nCategory And Author With Count:");
        foreach (var x in library.CategoryAndAuthorWithCount())
            Console.WriteLine($"Category:{x.Item1}, Author:{x.Item2}, Count:{x.Item3}");

        Console.WriteLine("\nTotal Price: " + library.CalculateTotal());
    }
}