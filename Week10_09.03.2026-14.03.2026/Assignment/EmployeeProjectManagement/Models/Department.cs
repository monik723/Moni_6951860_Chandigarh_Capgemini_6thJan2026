using EmployeeProjectManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeProjectManagement.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}