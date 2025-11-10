using DataBaseAccess;
using Microsoft.AspNetCore.Mvc;

namespace storeTechWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items=_context.categories.ToList();
            return View(items);
        }
    }
}
