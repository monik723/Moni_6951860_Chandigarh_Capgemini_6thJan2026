using Microsoft.AspNetCore.Mvc;

namespace StudentPortal1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return Content("Admin Dashboard");
        }
    }
}