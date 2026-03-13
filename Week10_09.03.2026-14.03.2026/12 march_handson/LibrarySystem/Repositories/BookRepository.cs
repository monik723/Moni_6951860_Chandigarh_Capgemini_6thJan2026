using LibrarySystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "C# Programming", Author = "John Smith" },
            new Book { Id = 2, Title = "ASP.NET Core", Author = "David Lee" },
            new Book { Id = 3, Title = "Database Systems", Author = "Robert Brown" }
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}