using EmployeeProjectManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeProjectManagement.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        public string Title { get; set; }

        public List<EmployeeProject>? EmployeeProjects { get; set; }
    }
}