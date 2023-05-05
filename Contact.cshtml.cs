using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mini_Project.Pages
{
    public class ContactModel : PageModel
    {
        public bool isok = false;
        public String firstName = "";
        public String lastName = "";
        public String message = "";
        public void OnGet()
        {
        }
        public void OnPost() 
        {
            isok = true;
            firstName = Request.Form["firstname"];
            lastName = Request.Form["lastName"];
            message = Request.Form["message"];
        }
    }
}
