using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Activiy_M3_WebApplication1.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; } = "";

        [BindProperty]
        public string Email { get; set; } = "";

        [BindProperty]
        public string Message { get; set; } = "";

        public string SuccessMessage { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            SuccessMessage = "Thank you for contacting me!";
        }
    }
}