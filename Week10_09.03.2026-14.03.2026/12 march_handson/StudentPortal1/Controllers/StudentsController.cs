using Microsoft.AspNetCore.Mvc;

namespace StudentPortal1.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}