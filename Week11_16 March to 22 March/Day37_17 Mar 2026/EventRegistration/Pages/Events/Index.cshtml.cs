using EventRegistration.Data;
using EventRegistration.Data;
using EventRegistration.Helpers;
using EventRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace EventRegistration.Pages.Events
{
    public class IndexModel : PageModel
    {
        public List<EventRegister> Registrations { get; set; }

        public void OnGet()
        {
            HttpContext.Session.SetString("role", "Admin");
            Registrations = HttpContext.Session.GetObject<List<EventRegister>>("data")
                            ?? new List<EventRegister>();
            
        }

        public IActionResult OnPostDelete(int id)
        {

            if (HttpContext.Session.GetString("role") != "Admin")
            {
                return Forbid();
            }

            var list = HttpContext.Session.GetObject<List<EventRegister>>("data")
                       ?? new List<EventRegister>();

            var item = list.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                list.Remove(item);
            }

            HttpContext.Session.SetObject("data", list);

            return RedirectToPage();
        }
    }
}
