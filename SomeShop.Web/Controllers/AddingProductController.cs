using Microsoft.AspNetCore.Mvc;
using SomeShop.Web.Data;
using SomeShop.Web.Models;
using System.Collections;

namespace SomeShop.Web.Controllers
{
    public class AddingProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AddingProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? id)
        {
            if (id == null && id == 0)
                return NotFound();
            IEnumerable<Product> products = _db.Products.Where(p => p.Id == id);
            return View(products);
        }
    }
}
