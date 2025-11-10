using DataBaseAccess;
using Microsoft.AspNetCore.Mvc;
using ModelClasses;

namespace storeTechWeb.Controllers
{
    public class CategoryController : Controller   // Declara una clase pública llamada CategoryController que hereda de la clase base 'Controller' de ASP.NET MVC.
    {
        private readonly ApplicationDBContext _context;  // Declara una variable privada y de solo lectura llamada _context, que almacenará una instancia del contexto de base de datos.

        public CategoryController(ApplicationDBContext context)   // Constructor del controlador, que recibe como parámetro el contexto de la base de datos (inyectado por dependencia).
        {
            _context = context;   // Asigna el contexto recibido al campo privado _context, para poder usarlo en los métodos del controlador.
        }

        public IActionResult Index()   // Define una acción pública llamada Index que devuelve un IActionResult (un tipo genérico de resultado en MVC).
        {
            
            var items = _context.categories.ToList();   // Obtiene todos los registros de la tabla 'categories' desde la base de datos y los convierte en una lista.
            return View(items);   // Devuelve la vista asociada al método (por convención, "Index.cshtml") y le pasa la lista de categorías como modelo.
        }

        public IActionResult Upsert(int? id)
        {
            if(id == 0 )
            {
                Category category = new Category();
                return View (category);
            }
            else
            {
                var category = _context.categories.FirstOrDefault(u=> u.Id==id);
                return View(category);
            }
        }
    }

}
