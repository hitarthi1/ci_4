using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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
    }
}
