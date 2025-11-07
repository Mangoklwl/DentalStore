using Microsoft.AspNetCore.Mvc;

namespace storeTechWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
