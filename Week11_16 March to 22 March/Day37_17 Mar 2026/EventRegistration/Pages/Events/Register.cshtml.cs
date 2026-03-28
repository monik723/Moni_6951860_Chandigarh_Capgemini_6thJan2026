using EventRegistration.Data;
using EventRegistration.Data;
using EventRegistration.Helpers;
using EventRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventRegistration.Pages.Events
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public EventRegister Registration { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            var list = HttpContext.Session.GetObject<List<EventRegister>>("data")
                       ?? new List<EventRegister>();

            Registration.Id = list.Count + 1;

            list.Add(Registration);

            
            HttpContext.Session.SetObject("data", list);
            TempData["Success"] = "Registered Successfully!";

            return RedirectToPage("Index");
        }
    }
}
