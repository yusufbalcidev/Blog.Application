using Blog.Application.Models.DataViewModels;
using EFIndentityDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Application.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //kullanici uzerinde kullanilabilir bircok metot saglar
        //readonly constractor uzerinden kullanim saglar
        private readonly UserManager<AppUser> _UserManager;

        //cokkie yonetimi icin
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _UserManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model, string? returnUrl = null)//return url ile kullanici giris yaptiktan sonra yonlendirilir

        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            returnUrl = returnUrl ?? Url.Action("Index", "Home");
            var hasUser = await _UserManager.FindByEmailAsync(model.Email);

            if (hasUser == null)
            {
                ModelState.AddModelError(string.Empty, "Email veya şifre hatalı");
                return View();
            }
            var SignInResult = await _signInManager.PasswordSignInAsync(hasUser, model.Password, model.RememberMe, true);

            if (SignInResult.Succeeded)
            {
                return Redirect(returnUrl);
            }
            if (SignInResult.IsLockedOut)
            {
                ModelState.AddModelErrorList(new List<string>() { "3 dakika sonra tekrar deneyiniz." });
                return View();

            }
            ModelState.AddModelErrorList(new List<string>()
            { $"Email veya şifre hatalı(Başarısız deneme sayısı={await _UserManager.GetAccessFailedCountAsync(hasUser)})" });
            return View();
        }
    }
}
