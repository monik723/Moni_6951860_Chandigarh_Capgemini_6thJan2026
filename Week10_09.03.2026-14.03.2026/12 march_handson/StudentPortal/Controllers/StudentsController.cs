using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using StudentPortal.Services;
using System.Collections.Generic;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IRequestLogService _logService;

        public StudentsController(IRequestLogService logService)
        {
            _logService = logService;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Amit", Age = 20 },
                new Student { Id = 2, Name = "Riya", Age = 21 },
                new Student { Id = 3, Name = "Rahul", Age = 22 }
            };

            ViewBag.Logs = _logService.GetLogs();

            return View("View", students);
        }
    }
}