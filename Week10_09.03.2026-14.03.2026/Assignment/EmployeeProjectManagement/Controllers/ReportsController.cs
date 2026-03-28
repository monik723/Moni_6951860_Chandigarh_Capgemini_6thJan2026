using EmployeeProjectManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeProjectManagement.Models;



namespace EmployeeProjectManagement.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult EmployeesByProject(int id)
        {
            var employees = _context.EmployeeProjects
                .Where(ep => ep.ProjectId == id)
                .Select(ep => ep.Employee)
                .ToList();

            return View(employees);
        }

        public IActionResult ProjectsByEmployee(int id)
        {
            var projects = _context.EmployeeProjects
                .Where(ep => ep.EmployeeId == id)
                .Select(ep => ep.Project)
                .ToList();

            return View(projects);
        }

        public IActionResult EmployeesPerDepartment()
        {
            var result = _context.Departments
                .Select(d => new
                {
                    Department = d.Name,
                    Count = d.Employees.Count()
                }).ToList();

            return View(result);
        }
    }
}
