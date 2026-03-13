using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Repositories;

namespace LibrarySystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            return View(book);
        }

        public IActionResult Index()
        {
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }
    }
}
