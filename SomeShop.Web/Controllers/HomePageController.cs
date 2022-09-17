using Microsoft.AspNetCore.Mvc;

namespace SomeShop.Web.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
