using Microsoft.AspNetCore.Mvc;

namespace Blog.Application.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
