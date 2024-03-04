using Microsoft.AspNetCore.Mvc;

namespace FoodAplication.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
