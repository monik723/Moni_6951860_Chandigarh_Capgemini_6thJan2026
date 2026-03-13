using LibrarySystem.Models;
using System.Collections.Generic;

namespace LibrarySystem.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);
    }
}