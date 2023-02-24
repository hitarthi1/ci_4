using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class PagesController : Controller
    {
        

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Forgot_password()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Header()
        {
            return View();
        }
      
        public IActionResult Mission()
        {
            return View();
        }
        public IActionResult Storylist()
        {
            return View();
        }

    }
}
