using Microsoft.AspNetCore.Mvc;

namespace NYK.WebApp.Areas.Main.Controllers
{
    [Area("Main")]
    public class AuthenController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
