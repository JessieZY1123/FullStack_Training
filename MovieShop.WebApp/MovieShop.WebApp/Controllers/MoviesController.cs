using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebApp.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
