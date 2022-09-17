using Microsoft.AspNetCore.Mvc;
using SomeShop.Web.Data;
using SomeShop.Web.Models;

namespace SomeShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        //get
        public IActionResult Index()
        {
            IEnumerable<Category> categoriesList = _db.Categories;
            return View(categoriesList);
        }
        //get
        public IActionResult Create ()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //get
        public IActionResult Edit (int? id) 
        {
            if (id==null && id==0)
                return NotFound();
            var category = _db.Categories.Find(id);
            if (category == null)
                return NotFound();
            return View(category);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //get
        public IActionResult Delete(int? id)
        {
            if (id == null && id == 0)
                return NotFound();
            Category category = _db.Categories.Find(id);
            if (category == null)
                return NotFound();
            return View(category);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost (int? id)
        {
            if (id == null && id == 0)
                return NotFound();
            Category category = _db.Categories.Find(id);
            if (category == null)
                return NotFound();
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
