using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mini_Project.Pages
{
    public class practiceModel : PageModel
    {
        public bool isok = false;
        public String firstName = "";
        public String lastName = "";
        public String message = "";
        public String name = "";
        public String a = "";
        public String b = "";
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            isok = true;
            /*firstName = Request.Form["firstname"];
            lastName = Request.Form["lastName"];
            message = Request.Form["message"];*/
            name = Request.Form["name"];
            a = Request.Form["a"];
            b = Request.Form["b"];
        }
    }
}
