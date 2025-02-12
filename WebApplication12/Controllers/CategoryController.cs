using Microsoft.AspNetCore.Mvc;
using WebApplication12.Data;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category) 
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
