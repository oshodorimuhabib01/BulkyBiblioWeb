using Microsoft.AspNetCore.Mvc;

namespace BulkyBiblioWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
