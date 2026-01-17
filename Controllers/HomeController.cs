using Microsoft.AspNetCore.Mvc;

namespace Blog.Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
