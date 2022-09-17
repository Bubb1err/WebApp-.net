using Microsoft.AspNetCore.Mvc;
using SomeShop.Web.Data;
using SomeShop.Web.Models;

namespace SomeShop.Web.Controllers
{
    public class ShoppingCategories : Controller
    {
        private readonly ApplicationDbContext _db;
        public ShoppingCategories(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _db.Categories;
            return View(categories);
        }
    }
}
